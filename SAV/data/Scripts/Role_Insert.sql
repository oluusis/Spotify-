INSERT INTO tb_Role
(
    Code,
    Name,
    Description
)
select
    'A'        AS  Code,
    'Admin'     AS   Name,
    'Právo dělat vše'       AS   Description
;


INSERT INTO tb_Role
(
    Code,
    Name,
    Description
)
select
    'U'        AS  Code,
    'User'     AS   Name,
    'Právo přehrávat si písničky, nemůže upravovat'       AS   Description
;


INSERT INTO tb_Role
(
    Code,
    Name,
    Description
)
select
    'G'        AS  Code,
    'Guest'     AS   Name,
    'Právo prohlížet si písničky, nemůže přehrávat, nemůže upravovat'       AS   Description
;