INSERT INTO tb_Songs
(
    Name,
    SongFile,
    DiscNo,
    TrackNo,
    Duration,
    Album_ID
)
select
    'Bloody valentine'              AS  Name,
    'C:\User\Benda\Files\x.mvc'     AS   SongFile,
    2                               AS   DiscNo,
    2                               AS   TrackNo,
    1.25                            AS   Duration,
    1                               AS   Album_ID
;