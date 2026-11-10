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
        Schema::create('pembayarans', function (Blueprint $table) {
            $table->id('id_pembayaran')->INT();
            $table->date('tgl_bayar')->NOTNULL();
            $table->string('bulan_bayar')->VARCHAR(15)->NOTNULL();
            $table->string('tahun_dibayar')->VARCHAR(15)->NOTNULL();
            $table->string('jumlah_bayar')->INT()->NOTNULL();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('pembayarans');
    }
};
