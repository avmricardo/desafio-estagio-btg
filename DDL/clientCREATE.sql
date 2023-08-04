-- Table: public.client

-- DROP TABLE IF EXISTS public.client;

CREATE TABLE IF NOT EXISTS public.client
(
    id_client integer NOT NULL DEFAULT nextval('client_id_client_seq'::regclass),
    cpf character varying(11) COLLATE pg_catalog."default" NOT NULL,
    name character varying(100) COLLATE pg_catalog."default" NOT NULL,
    telephone character varying(20) COLLATE pg_catalog."default" NOT NULL,
    address character varying(100) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT pk_client PRIMARY KEY (id_client),
    CONSTRAINT unique_cpf UNIQUE (cpf)
        INCLUDE(cpf)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.client
    OWNER to postgres;