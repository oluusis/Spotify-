INSERT INTO tb_Albums
(
    Title,
    Year,
    Description,
    ImageFile,
    Artist_ID
)
SELECT
    'Born with horns'     as Title,
    2005                  as Year,
    'New album'                    as Description,
    'c:\Users\...'                    as ImageFile,
    1                    as     Artist_ID
;