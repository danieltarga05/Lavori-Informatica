using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace subnet_mask
{
    internal class Program
    {
        static byte[] subnet_mask = {255, 255, 255, 0};
        static byte[] ip_address = {192, 168, 1, 0};
        static void Main(string[] args)
        {
            uint[] firstAddress = new uint[subnet_mask.Length];
            string[] binaryAddress = new string[subnet_mask.Length];
            uint[] Ip = new uint[ip_address.Length];
            string[] binip = new string[ip_address.Length];
            uint[] or = new uint[subnet_mask.Length];
            for (int i = 0; i < 4; i++)
            {
                Ip[i] = Convert.ToUInt32(ip_address[i]);
                binip[i] = Convert.ToString(Ip[i], toBase: 2);
                firstAddress[i] = Convert.ToUInt32(subnet_mask[i]);
                binaryAddress[i] = Convert.ToString(firstAddress[i], toBase: 2);
                


            }
            Array.Sort(binaryAddress);
            for (int i = 0; i < or.Length; i++)
            {
                or[i] = Convert.ToUInt32(binaryAddress[i]) | Convert.ToUInt32(binip[i]);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(or[i]);
            }
            Console.ReadLine();
        }
    }

        /// <summary>
        /// Assign the input parameter to the attribute of the subnet_mask.
        /// OBS: Attributes of the class will be erased if previously assigned AND subnet parameter is wrong.
        /// </summary>
        /// <param name="sm">Subnet Mask</param>

        /*static byte[] PrintBroadcastAddress()
        {
           
    }*/


        
    }