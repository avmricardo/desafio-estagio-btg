-- Table: public.transaction

-- DROP TABLE IF EXISTS public.transaction;

CREATE TABLE IF NOT EXISTS public.transaction
(
    id_transaction integer NOT NULL DEFAULT nextval('transaction_id_transaction_seq'::regclass),
    value money,
    id_account integer NOT NULL,
    date timestamp without time zone NOT NULL,
    type_transaction integer NOT NULL,
    CONSTRAINT pk_transaction PRIMARY KEY (id_transaction),
    CONSTRAINT id_account FOREIGN KEY (id_account)
        REFERENCES public.account (id_account) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.transaction
    OWNER to postgres;