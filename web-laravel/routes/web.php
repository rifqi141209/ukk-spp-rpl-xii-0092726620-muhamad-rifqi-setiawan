<?php

use App\Http\Controllers\AuthController;
use Faker\Guesser\Name;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('layout');
});

Route::get('login', [authController::class 'login'])
Route::post('login', [AuthController::class 'proseslogin']);