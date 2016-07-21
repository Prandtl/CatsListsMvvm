namespace CatsLists.Core.Services
{
	public interface IKittenGenesisService
	{
		Kitten GenerateKitten(string extra = "");
	}
}
