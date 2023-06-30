using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi6
{
    internal class MangMotChieu
    {
        public void Bai1()
        {
            Console.WriteLine("------------------***Bài 1&2***------------------");
            int sumle = 0;
            int sumchan = 0;
            int count = 0;
            Random random = new Random();
            int[] listArray = new int[10];

            for (int i = 0; i <= listArray.Length - 1; i++)
            {
                listArray[i] = random.Next(0, 100);
                if (listArray[i] % 2 != 0)
                    sumle += listArray[i];
                else
                    sumchan += listArray[i];


                for (int j = i + 1; j < listArray.Length; j++)
                {
                    if (listArray[i] == listArray[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.Write("Mảng Random là:");
            foreach (int array in listArray)
            {
                Console.Write("{0} ", array);

            }

            Console.WriteLine(Environment.NewLine);

            Array.Reverse(listArray);
            Console.Write("Mảng đảo chiều là:");
            foreach (int array in listArray)
            {
                Console.Write("{0} ", array);

            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Tổng các phần tử lẻ là: {0}", sumle);
            Console.WriteLine("Tổng các phần tử chẵn là: {0}", sumchan);

        }

        public void Bai3()
        {
            Console.WriteLine("------------------***Bài 3 đếm số lượng phần tử trùng lặp***------------------");
            Console.Write("Nhập số phần tử trong mảng:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }

            foreach (int arr in array)
            {
                Console.Write("{0} ", arr);

            }
         
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("---------***Đếm số lần lặp lại***---------");

            var distinctValues = array.Distinct().ToArray();

            for (int i = 0; i < distinctValues.Length; i++)
            {
                var cnt = array.Count(x => x == distinctValues[i]);
                Console.WriteLine($"Giá trị {distinctValues[i]}, xuất hiện {cnt} lần");
            }

            Console.WriteLine("---------***Tìm phần tử lớn nhất trong mảng***---------");
            int max = 0, min = 0;
            max = array[0];
            min = array[0];

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Giá trị lớn nhất trong mảng là: " + max);
            Console.WriteLine("Giá trị nhỏ nhất trong mảng là: " + min);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("---------***Tìm phần tử lớn,nhỏ thứ n trong mảng***---------");
            Console.Write("Nhập vị trí phần tử cần tìm: ");
            int m = int.Parse(Console.ReadLine());
            Array.Sort(array);
            Console.WriteLine("Phần tử lớn thứ {0} của mảng là {1}", m, array[array.Length - m]);
            Console.WriteLine("Phần tử nhỏ thứ {0} của mảng là {1}", m, array[m - 1]);

           

           
        }
        public void Bai4()
        {
            Console.Write("Nhập số phần tử trong mảng:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }

            foreach (int arr in array)
            {
                Console.Write("{0} ", arr);

            }
            Console.Write("Nhập giá trị cần chèn: ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("Nhập vị trí cần chèn: ");
            int index = int.Parse(Console.ReadLine());

            Array.Resize(ref array, array.Length + 1);
            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = value;

            foreach (int element in array)
            {
                Console.Write(" " + element);
            }


            Console.Write("\nNhập vị trí cần xóa: ");
            int indexDrop = int.Parse(Console.ReadLine());
            array = array.Where((val, idx) => idx != indexDrop).ToArray();
            foreach (int element in array)
            {
                Console.Write(" " + element);
            }

            Console.WriteLine(Environment.NewLine);
            int[] arr2 = new int[10]; // mang chua cac phan tu chan
            int[] arr3 = new int[10];
            int countPTL = 0, countPTC = 0;

            Console.Write("-----------***Chia mang thanh mang chan, mang le trong C#:***-----------");


            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    arr2[countPTC] = array[i];
                    countPTC++;
                }
                else
                {
                    arr3[countPTL] = array[i];
                    countPTL++;
                }
            }

            Console.Write("\nCac phan tu chan la: \n");

            foreach (int elementorChan in arr2)
            {
                Console.Write("{0} ", elementorChan);
            }

            Console.Write("\nCac phan tu le la: \n");
            foreach (int elementorLe in arr3)
            {
                Console.Write("{0} ", elementorLe);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("---------***Tìm Vị trí***---------");

            Console.Write("Nhập giá trị cần tìm:");
            int valueSearch = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (array[i] == valueSearch)
                {
                    //nếu nó bằng nhau thì hiển thị ra màn hình vị trí tồn tại của số đó
                    Console.WriteLine("\n {0} dang ton tai o vi tri {1}", valueSearch, i + 1);
                    break;
                }
            }

            Console.WriteLine("---------***Sắp xếp tăng dần***---------");
            Array.Sort(array);
            foreach (int element in array)
            {
                Console.Write(" " + element);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("---------***Sắp xếp giảm dần***---------");
            Array.Reverse(array);
            foreach (int element in array)
            {
                Console.Write(" " + element);
            }
        }

    }
}
