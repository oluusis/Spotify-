using SAV.Repos;
using SAV.Services;

namespace SAV
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArtistService service = new ArtistService();
            var list = service.GetArtists();

            foreach (var artist in list)
            {
                Console.WriteLine(artist.Name);
            }

            SongService songService = new SongService();

            var list2 = songService.GetSongs();

            foreach (var song in list2)
            {
                Console.WriteLine(song.ID);
            }

            AlbumService albumService = new AlbumService();

            var list1 = albumService.GetAlbums();

            foreach (var item in list1)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}