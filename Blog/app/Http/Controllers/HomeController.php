<?php

namespace App\Http\Controllers;
use App\Models\Post;
use Illuminate\Http\Request;

class HomeController extends Controller
{
    public function welcome()
    { 
        $dbgetList = Post::all();

       // return view('welcome');
        return view('welcome',['Post' => $dbgetList]);
    }
    public function Index($postID)
    {
        $getpost = Post::find($postID);
        if(is_null($getpost)){
            return to_route('welcome');
        }
        return view('Index',['Post' => $getpost]);
    }
    public function create(){
        

        return view('create');
    }

    public function store(Request $request){
        $data = Post::create([
            'Title' => $request->input('Title'),
            'Description' => $request->input("Description") ,  
         ]) ;
   

        return to_route('welcome');
    }
    
    public function update($postID){
        
        $getpost = Post::find($postID);
        if(is_null($getpost)){
            return to_route('welcome');
        }
        return view('update',['Post' => $getpost]);
    }

    public function updateID(Request $request,$postID){
        $post = Post::find($postID);

        // Check if post exists
        if (!$post) {
            return redirect()->back()->with('error', 'Post not found.');
        }
       
        $post ->Title = $request->input('Title');
        $post ->Description= $request->input("Description");
        $post ->save();
      

        return to_route('welcome');
    }
    public function delete($postID){
        
        $getpost = Post::find($postID);
        $getpost->delete();
        //for delete all rows
        //$getpost::truncate();
        return to_route('welcome');
    }
    // <a  href="{{route('delete',$post['id'])}}" class="btn btn-danger " >Delete</a>
}
