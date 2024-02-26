@extends('shared/_Layout')

@section('content')
<h3>Update</h3>

<div class="container m-5 w-50 p-5">
    <h3 class="text-align-center"> Update Post  </h3>
    <form method="POST" action="{{ route('updateID', ['id' => $Post->id]) }}" >
    <input name="_method" type="hidden" value="PATCH">
    @csrf
    @method('PATCH')
    <input type="text" name="Title" value="{{$Post->id}}" class="form-control mt-3" placeholder="Post Title">

    <input type="text" name="Description" value="{{$Post->Description}}" class="form-control mt-3 w-100" placeholder="Enter Post Description" > </textarea>

    <!-- <input type="date" class="form-control mt-3 " > -->

    <input type="submit" class="btn btn-success mt-3">

</form>

</div>
@endsection