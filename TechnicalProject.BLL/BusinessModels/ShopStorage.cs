namespace TechnicalProject.BLL.BusinessModels
{
    public class ShopStorage
    {
        public ShopStorage(string nameProd, int countProd)
        {
            _nameProd = nameProd;
            _countProd = countProd;
        }

        private string _nameProd;
        private int _countProd;

        public int ChangeCountProd(int countWarehouse)
        {
            return countWarehouse - _countProd;
        }
    }
}
