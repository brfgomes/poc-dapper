FROM postgres:latest

# ENV POSTGRES_DB=mydatabase
# ENV POSTGRES_USER=myuser
# ENV POSTGRES_PASSWORD=mypassword

EXPOSE 5432

# Copie um arquivo SQL de inicialização para o contêiner (opcional)
COPY init.sql /docker-entrypoint-initdb.d/