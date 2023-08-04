-- Table: public.account

-- DROP TABLE IF EXISTS public.account;

CREATE TABLE IF NOT EXISTS public.account
(
    id_account integer NOT NULL DEFAULT nextval('account_id_account_seq'::regclass),
    id_client integer NOT NULL,
    "number" integer NOT NULL DEFAULT nextval('account_number_seq'::regclass),
    balance money NOT NULL DEFAULT 0.0,
    CONSTRAINT pk_account PRIMARY KEY (id_account),
    CONSTRAINT unique_client UNIQUE (id_client)
        INCLUDE(id_client),
    CONSTRAINT unique_number UNIQUE ("number")
        INCLUDE("number"),
    CONSTRAINT fk_client FOREIGN KEY (id_client)
        REFERENCES public.client (id_client) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.account
    OWNER to postgres;