using System.Collections.Generic;
using CatsLists.Core.Services;
using MvvmCross.Core.ViewModels;

namespace CatsLists.Core.ViewModels
{
	public class FirstViewModel
		: MvxViewModel
	{
		public FirstViewModel(IKittenGenesisService service)
		{
			var catList = new List<Kitten>();
			for (int i = 0; i < 100; i++)
			{
				var cat = service.GenerateKitten(i.ToString());
				_kittens.Add(cat);
			}
			_kittens = catList;
		}

		private List<Kitten> _kittens;

		public List<Kitten> Kittens
		{
			get { return _kittens; }
			set { SetProperty(ref _kittens, value); RaisePropertyChanged(() => Kittens); }
		}
	}
}
