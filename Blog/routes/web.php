<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\HomeController;
/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

/*Route::get('/', function () {
    return view('welcome');
});*/
//Route::request_type('/url', 'ControllerName@functionName');
//Route::get('/', 'HomeController@welcome')->name('welcome');
//Route::get('/index','HomeController@Index')->name('Index');

//welcome
Route::get('/', [HomeController::class, 'welcome'])->name('welcome');
Route::get('/HomeController/{post}', [HomeController::class, 'index'])->name('index');

Route::get('/HomeController', [HomeController::class, 'create'])->name('create');
Route::post('/HomeController',[HomeController::class , 'store'])-> name('store');

Route::get('/HomeController/update/{id}',[HomeController::class , 'update'])-> name('update');
Route::PATCH('/HomeController/updateID/{id}',[HomeController::class , 'updateID'])-> name('updateID');
Route::delete('/HomeController/delete/{id}',[HomeController::class , 'delete'])-> name('delete');



//Route::match(['patch', 'put'], '/HomeController/updateID/{id}', [HomeController::class, 'updateID'])->name('updateID');