using System.ComponentModel.DataAnnotations;

namespace AyseYilmazPortfolio.DataAccessLayer.Entites
{
	public class SocailMedia
	{
		[Key]
		public int SocialMediaId { get; set; }
		public string Title { get; set; }
		public string Url { get; set; }
		public string Icon { get; set; }
	}
}
