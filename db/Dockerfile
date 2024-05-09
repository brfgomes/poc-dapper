FROM postgres:latest

ENV POSTGRES_DB=postgres
ENV POSTGRES_USER=postgres
ENV POSTGRES_PASSWORD=1234

EXPOSE 5433

# Copie um arquivo SQL de inicialização para o contêiner (opcional)
COPY init.sql /docker-entrypoint-initdb.d/

# Permissões e propriedades para o arquivo SQL
RUN chmod a+r /docker-entrypoint-initdb.d/init.sql
RUN chown postgres:postgres /docker-entrypoint-initdb.d/init.sql

# Comando para rodar o SQL durante a inicialização do contêiner
CMD ["postgres", "-c", "config_file=/etc/postgresql/postgresql.conf"]
