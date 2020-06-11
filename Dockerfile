FROM postgres:12.2-alpine
ENV POSTGRES_PASSWORD Mighty
ENV POSTGRES_DB mighty-gaming
COPY MightyDatabase_create.sql /docker-entrypoint-initdb.d/
COPY ./MightyDatabase_drop.sql ./MightyDatabase_drop.sql
EXPOSE 5432