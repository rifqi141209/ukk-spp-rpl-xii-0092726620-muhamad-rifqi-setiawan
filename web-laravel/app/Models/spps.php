<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class spps extends Model
{
    protected $fillable = [
        'id_user',
        'tahun',
        'nominal',
        'keterangan',
        'created_at',
        'updated_at',
    ];
}
