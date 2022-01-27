//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ParallelProcessing
//{
//    int mostBalancedPartition(vector<int> parent, vector<int> files_size)
//    {
//        // O(N) here
//        long totalSize = files_size[0]+ files_size[files_size.count-1];
//        long result = 0;
//        long i = files_size.size();
//        // and O(N) here
//        while (--i)
//        {
//            files_size[parent[i]] += files_size[i];
//            result = min(result, Math.Abs(totalSize - 2 * files_size[i]));
//        }
//        return result;
//    }
//}//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ParallelProcessing
//{
//    int mostBalancedPartition(vector<int> parent, vector<int> files_size)
//    {
//        // O(N) here
//        long totalSize = files_size[0]+ files_size[files_size.count-1];
//        long result = 0;
//        long i = files_size.size();
//        // and O(N) here
//        while (--i)
//        {
//            files_size[parent[i]] += files_size[i];
//            result = min(result, Math.Abs(totalSize - 2 * files_size[i]));
//        }
//        return result;
//    }
//}
