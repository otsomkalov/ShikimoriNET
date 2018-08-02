# ShikimoriNET

Как пользоваться:
<pre>
  var api = new ShikimoriApi();
  var animes = await api.Anime.SearchAsync(new SearchParams
  {
      Search = "Naruto",
      Limit = 10
  });
</pre>
