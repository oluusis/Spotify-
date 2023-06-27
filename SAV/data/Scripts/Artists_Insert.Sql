INSERT INTO  tb_Artists
(
    Name,
    Description,
    CountryCode,
    ActiveFrom,
    ActiveTo,
    ImageFile
)
select
    'Machine Gun Kelly'         as      NAME,
    'Nejlepší zpěvák všech dob' as      Description,
    'US'                        as      CountryCode,
    '1998-04-27 00:00:00'       as      ActiveFrom,
    '1998-04-27 00:00:00'       as      ActiveTo,
    'C:\User\Benda\Files\x.jpg' as      ImageFile
;
