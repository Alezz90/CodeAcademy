@extends('shared/_Layout')

@section('content')
<h3>welcome</h3>
<a href="{{route('create')}}" class="btn btn-primary">Create New Post </a>
<div>
   
    <div class="row row-cols-1 row-cols-md-3 g-4">
        @foreach($Post as $post)
  <div class="col">
    <div class="card h-100">
      <img src="..." class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title">{{$post['id']}}</h5>
        <p class="card-text">{{$post['Title'] }}</p>
        <p class="card-subtext">{{$post['Description']}}</p>
        <p class="card-subtext">{{$post['added_at']}}</p>
    <div class="d-flex justify-content-between">
    <a href="{{route('index',$post['id'])}}" class="btn btn-warning">View</a>
    <!-- /posts/{{$post['id']}} -->
    <a href="{{route('update',$post['id'])}}" class="btn btn-secondary">Update</a>
    <form action="{{route('delete',$post['id'])}}" method="post">
    @csrf
    @method('Delete')
                    <button class="btn btn-default" type="submit">Delete</button>
                </form>
   
    </div>
      </div>
      <div class="card-footer">
        <small class="text-muted">Last updated 3 mins ago</small>
      </div>
    </div>
  </div>
  

  
  @endforeach
  
</div>
</div>
@endsection