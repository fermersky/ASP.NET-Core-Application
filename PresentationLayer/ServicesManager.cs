using BusinessLayer;
using PresentationLayer.Services;

namespace PresentationLayer
{
    public class ServicesManager
    {
        DataManager _dataManager;

        private BooksService _booksService;

        public BooksService BooksService
        {
            get => _booksService;
        }


        public ServicesManager(DataManager dataManager)
        {
            _dataManager = dataManager;
            _booksService = new BooksService(_dataManager);
        }

    }

    //public class ServicesManager
    //{
    //    DataManager _dataManager;
    //    private DirectoryService _directoryService;
    //    private MaterialService _materialService;

    //    public ServicesManager(
    //        DataManager dataManager
    //        )
    //    {
    //        _dataManager = dataManager;
    //        _directoryService = new DirectoryService(_dataManager);
    //        _materialService = new MaterialService(_dataManager);
    //    }
    //    public DirectoryService Directorys { get { return _directoryService; } }
    //    public MaterialService Materials { get { return _materialService; } }

    //}
}