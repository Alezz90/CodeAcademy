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
           <input name="_method" type="hidden" value="DELETE">
           <button type="submit" class="btn btn-xs btn-danger btn-flat show_confirm" data-toggle="tooltip" title='Delete'>Delete</button>
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
<script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.0/sweetalert.min.js"></script>
<script type="text/javascript">
 
     $('.show_confirm').click(function(event) {
          var form =  $(this).closest("form");
          var name = $(this).data("name");
          event.preventDefault();
          swal({
              title: `Are you sure you want to delete this record?`,
              text: "If you delete this, it will be gone forever.",
              icon: "warning",
              buttons: true,
              dangerMode: true,
          })
          .then((willDelete) => {
            if (willDelete) {
              form.submit();
            }
          });
      });
  
</script>
@endsection