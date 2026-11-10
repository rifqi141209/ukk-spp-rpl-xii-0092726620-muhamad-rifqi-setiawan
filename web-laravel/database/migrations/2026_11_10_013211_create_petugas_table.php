<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('petugas', function (Blueprint $table) {
            $table->id('id_petugas')->INT();
            $table->string('username')->VARCHAR(30)->NOTNULL();
            $table->string('password')->VARCHAR(255)->NOTNULL();
            $table->string('nama_petugas')->VARCHAR(50)->NOTNULL();
            $table->text('level')->enum;
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('petugas');
    }
};
