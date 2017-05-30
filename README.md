# SpotOsu!
Desktop application to create spotify playlists from osu!
  - Load collections.
  - Customize your playlist.
  - Enjoy!
### Download
   - [Relases](https://github.com/ByBordex/SpotOsu/releases)
  
### Usage 
  - Select osu path and press Load (Default one is already selected).
  - Select the collection to load or every beatmap.
  - Tweak your selection.
  - Place an Spotify API clientID token.
  - Input a playlist name
  - Press create playlist button.
  - [Step-By-Step Video](https://www.youtube.com/watch?v=omc558isym4)
### Setup Spotify Application

- [Create spotify Application](https://developer.spotify.com/my-applications/#!/applications/create), you can use whichever name and description you want.
- Accept terms of service if needed.
- Put http://localhost:8000 as Redirect URIs and press "Add"
- Scroll to the bottom and press save.
- Copy Client ID and use it for SpotOsu!
### Notes
- When selecting "all" as collection it will load every beatmap into the song's and playlist's lists, however when creating the playlist a maximum o 400 are going to be parsed for creating the list due to SpotifyAPI limitations. (The maximum is 400, however a songs may not be found in spotify thus reducing the number of songs in the playlist.)
### Credits 

- JohnnyCrazy: [Spotify API Wrapper](https://github.com/JohnnyCrazy/SpotifyAPI-NET).
- Holly-Hacker: [Osu! database reader](https://github.com/HoLLy-HaCKeR/osu-database-reader).
- Ppy: [osu!](https://osu.ppy.sh/)[ppy](https://ppy.sh/)
- Spotify team: [Spotify](https://www.spotify.com)
