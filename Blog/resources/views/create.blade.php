@extends('shared/_Layout')

@section('content')
<h3>create</h3>

<div class="container m-5 w-50 p-5">
    <h3 class="text-align-center"> Create new Post  </h3>
    <form method="POST" action="{{route('store')}}" >
    @csrf

    <input type="text" name="Title" class="form-control mt-3" placeholder="Post Title">

    <textarea name="Description" id=""  class="form-control mt-3 w-100" placeholder="Enter Post Description" > </textarea>

    <!-- <input type="date" class="form-control mt-3 " > -->

    <input type="submit" class="btn btn-success mt-3">

</form>
</div>
@endsection