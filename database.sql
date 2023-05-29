CREATE TABLE prodi
(
    kd_prodi character(7) COLLATE pg_catalog."default" NOT NULL,
    nama_prodi text COLLATE pg_catalog."default",
    CONSTRAINT prodi_pkey PRIMARY KEY (kd_prodi)
);

INSERT INTO prodi(kd_prodi, nama_prodi)
	VALUES ('1010', 'Sistem Informasi');

INSERT INTO prodi(kd_prodi, nama_prodi)
	VALUES ('2010', 'Teknologi Informasi');
	
INSERT INTO prodi(kd_prodi, nama_prodi)
	VALUES ('3010', 'Informatika');

CREATE TABLE mahasiswa
(
    nim character(12) COLLATE pg_catalog."default" NOT NULL,
    nama text COLLATE pg_catalog."default" NOT NULL,
    alamat text COLLATE pg_catalog."default",
    tgl_lahir date,
    kd_prodi character(7) COLLATE pg_catalog."default" NOT NULL,
    ukt money,
    is_active boolean,
    CONSTRAINT mahasiswa_pkey PRIMARY KEY (nim),
    CONSTRAINT mahasiswa_kd_prodi_fkey FOREIGN KEY (kd_prodi)
        REFERENCES prodi (kd_prodi) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)