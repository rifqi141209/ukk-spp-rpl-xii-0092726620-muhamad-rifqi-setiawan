<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class siswas extends Model
{
    protected $fillable = [
        'nisn',
        'nis',
        'name',
        'id_kelas',
        'alamat',
        'no_telp',
        'id_spp',
        'created_at',
        'updated_at',
    ];
}
