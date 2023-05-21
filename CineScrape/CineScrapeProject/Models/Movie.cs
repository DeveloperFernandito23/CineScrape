﻿namespace CineScrapeProject.wwwroot.Models
{
	public class Movie
	{
		private int _id;
		private string _title;
		private string _poster_url;
		private string _trailer;
		private int? _rateCritic;
		private int? _rateAudience;
		private List<Platform> _platforms = new();
		private List<string> _photos = new();
		private string _description;
		private Dictionary<string, string> _characteristics = new();
		private List<Cast> _casts = new();
		private List<Review> _reviews = new();

		public int Id { get => _id; set => _id = value; }
		public string Title { get => _title; set => _title = value; }
		public string Poster_url { get => _poster_url; set => _poster_url = value; }
		public string Trailer { get => _trailer; set => _trailer = value; }
		public int? RateCritic { get => _rateCritic; set => _rateCritic = value; }
		public int? RateAudience { get => _rateAudience; set => _rateAudience = value; }
		public List<Platform> Platforms { get => _platforms; set => _platforms = value; }
		public List<string> Photos { get => _photos; set => _photos = value; }
		public string Description { get => _description; set => _description = value; }
		public Dictionary<string, string> Characteristics { get => _characteristics; set => _characteristics = value; }
		public List<Cast> Casts { get => _casts; set => _casts = value; }
		public List<Review> Reviews { get => _reviews; set => _reviews = value; }
	}
}
