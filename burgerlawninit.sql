Create Table clients(id int, name text, address text, pay_date date);
create table services_offered(id int, name text, cost_per_hour money);
create table client_services(id int, client_id int, services_id int, bid_price money,due_date date, completion_date date, paid int);
create table timekeeping(id int,client_service_id int,time_taken text, creation_date date);
create table user_account(id int, email text,name text, company text, creation_date date, modified_date date,delete_date date);
create table user_pass(id int, hash text,reset_hash text, creation_date date, expire_date date, modified_date date,delete_date date);
create table user_kmli(id int, hash text,reset_hash text, creation_date date, expire_date date, modified_date date,delete_date date);
create table user_forgot(id int, user_id int, hash text, creation_date date, expire_date date, modified_date date,delete_date date);

