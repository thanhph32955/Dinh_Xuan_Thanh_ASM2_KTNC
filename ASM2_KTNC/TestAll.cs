using Bai1;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace ASM2_KTNC
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Tong2SoNguyen
        [TestCase(2,3,5,true)]
        [TestCase(2,3,6,false)]
        [TestCase(2,-3,-1,true)]
        [TestCase(2,0,2,true)]
        [TestCase(0,0,0,true)]
        [TestCase(0,0,1,false)]
        [TestCase(-2,0,-2,true)]
        [TestCase(-2,-3,-5,true)]
        [TestCase(-2,-3,-6,false)]
        [TestCase(-2,3,1,true)]

        public void TestTong2SoNguyen(int a, int b, int expected, bool isInt)
        {
            Tong2SoNguyen tong2SoNguyen = new Tong2SoNguyen();
            if (isInt)
            {
                Assert.AreEqual(expected, tong2SoNguyen.Tong(a, b));
            }
            else
            {
                Assert.AreEqual(expected, tong2SoNguyen.Tong(a, b));
            }
        }

        #endregion

        #region Tich2SoNguyen
        [TestCase(2,3,6,true)]
        [TestCase(2,3,5,false)]
        [TestCase(2,-3,-6,true)]
        [TestCase(2,0,0,true)]
        [TestCase(0,0,0,true)]
        [TestCase(0,0,1,false)]
        [TestCase(-2,0,0,true)]
        [TestCase(-2,-3,6,true)]
        [TestCase(-2,-3,5,false)]
        [TestCase(-2,3,-6,true)]

        public void TestTich2SoNguyen(int a, int b, int expected, bool isInt)
        {
            Tich2SoNguyen tich2SoNguyen = new Tich2SoNguyen();
            if (isInt)
            {
                Assert.AreEqual(expected, tich2SoNguyen.Tich(a, b));
            }
            else
            {
                Assert.AreEqual(expected, tich2SoNguyen.Tich(a, b));
            }
        }

        #endregion

        #region Hieu2SoNguyen
        [TestCase(2,3,-1,true)]
        [TestCase(2,3,6,false)]
        [TestCase(2,-3,5,true)]
        [TestCase(2,0,2,true)]
        [TestCase(0,0,0,true)]
        [TestCase(0,0,1,false)]
        [TestCase(-2,0,-2,true)]
        [TestCase(-2,-3,1,true)]
        [TestCase(-2,-3,6,false)]
        [TestCase(-2,3,-5,true)]

        public void TestHieu2SoNguyen(int a, int b, int expected, bool isInt)
        {
            Hieu2SoNguyen hieu2SoNguyen = new Hieu2SoNguyen();
            if (isInt)
            {
                Assert.AreEqual(expected, hieu2SoNguyen.Hieu(a, b));
            }
            else
            {
                Assert.AreEqual(expected, hieu2SoNguyen.Hieu(a, b));
            }
        }

        #endregion

        #region TinhTBCCua1List

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 5, 7 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5.5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 6)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 11, 12 }, 6.5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 6.5)]
        [TestCase(new int[] { 1, 29, 10, 11, 13 }, 12.8)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, 7)]
        [TestCase(new int[] { 1, 2, 3, 43, 14 }, 12.6)]
        public void TestTinhTBCCua1List(int[] array, double expected)
        {
            TinhTBCCua1List tinhTBCCua1List = new TinhTBCCua1List();
            List<int> list = new List<int>(array);
            Assert.AreEqual(expected, tinhTBCCua1List.TinhTBCCuaList(list));
        }
        #endregion

        #region TruyXuatPhanTuMang
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, 5)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 1, 20)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 3, 40)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 0, 10)]
        [TestCase(new int[] { 10, 20, 30, 40, 50 }, 4, 50)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 9, 10)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 6)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 11,12)]   

        public void TestTruyXuat(int[] array, int index, int expected)
        {
            TruyXuatPhanTuMang utilities = new TruyXuatPhanTuMang();
            int result = utilities.TruyXuat(array, index);
            Assert.AreEqual(expected, result);
        }


        #endregion

    }
}