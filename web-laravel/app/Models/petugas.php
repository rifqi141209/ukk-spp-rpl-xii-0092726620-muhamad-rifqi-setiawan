<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Monolog\Level;
use Illuminate\Foundation\Auth\User;

class petugas extends Model
{
    protected $fillable = [
        'id_petugas',
        'username',
        'password',
        'nama_petugas',
        'level',
        'created_at',
        'updated_at',
    ];

    protected $hidden = [
        'password',
        'remember_token',
    ];

}
