SELECT * FROM users.users;
insert into users (first_name, last_name, email) values ('Jane', 'Doe', 'jane@doe.com'), ('Bob', 'Ross', 'bob@ross.com'), ('James', 'Kirk', 'james@kirk.com');
SELECT * FROM users where email='jane@doe.com';
SELECT * FROM users where id=3;
UPDATE users SET last_name='Pancakes' WHERE id=3;
DELETE FROM users WHERE id=2;
SELECT * FROM users ORDER BY first_name;
SELECT * FROM users ORDER BY first_name DESC;