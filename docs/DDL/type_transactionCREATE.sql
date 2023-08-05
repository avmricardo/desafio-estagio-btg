-- Table: public.type_transaction

-- DROP TABLE IF EXISTS public.type_transaction;

CREATE TABLE IF NOT EXISTS public.type_transaction
(
    type integer,
    description character varying(10) COLLATE pg_catalog."default"
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.type_transaction
    OWNER to postgres;