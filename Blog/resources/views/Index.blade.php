@extends('shared/_Layout')

@section('content')
<h3>Index</h3>
<div>
    <div class="row row-cols-1 row-cols-md-3 g-4">
      
  <div class="col">
    <div class="card h-100">
     
      <div class="card-body">
        <h5 class="card-title">{{$Post->id}}</h5>
        <p class="card-text">{{$Post->Title}}</p>
        <p class="card-subtext">{{$Post->Description}}</p>
      
    <div class="d-flex justify-content-between">
   
    <a href="" class="btn btn-secondary">Update</a>
    
    <a href="" class="btn btn-danger " >Delete</a>
    </div>
      </div>
      <div class="card-footer">
        <small class="text-muted">Last updated 3 mins ago</small>
      </div>
    </div>
  </div>

  
</div>
</div>
@endsection