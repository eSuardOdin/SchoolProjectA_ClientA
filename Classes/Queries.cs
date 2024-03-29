﻿using SchoolProjectA_ClientA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace SchoolProjectA_ClientA.Classes
{
    public static class Queries
    {
        /// <summary>
        /// Trie les monis pour voir s'il en existe un avec le login du champ de login
        /// </summary>
        /// <param name="loginTxt">La textBox à checker</param>
        /// <returns>Un moni, null si le pseudo n'existe pas</returns>
        public static async Task<Moni> GetMoni(string loginTxt)
        {
            using HttpClient client = new HttpClient();
            Moni moni = null;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage res = await client.GetAsync("http://raspberry:5000/moni"); //http://192.168.30.10:5000/moni
                if (res.IsSuccessStatusCode)
                {
                    List<Moni> monis = await res.Content.ReadFromJsonAsync<List<Moni>>();
                    moni = monis.Find(x => x.MoniLogin == loginTxt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return moni;
        }

        /// <summary>
        /// Check le mot de passe d'un Moni par rapport au champ password
        /// </summary>
        /// <param name="moni">Le moni à checker</param>
        /// <returns>Le moni si password ok</returns>
        public static async Task<Moni> CheckMoni(Moni moni, string pwd)
        {
            using HttpClient client = new HttpClient();
            Moni? checkedMoni = null;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage res = await client.GetAsync($"http://raspberry:5000/moni/{moni.MoniId}?moniPwd={pwd}");
                if (res.IsSuccessStatusCode)
                {
                    //List<Moni> monis = await res.Content.ReadFromJsonAsync<List<Moni>>();
                    checkedMoni = await res.Content.ReadFromJsonAsync<Moni>();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return checkedMoni;
        }

        /// <summary>
        /// Post d'un moni
        /// </summary>
        /// <param name="moni">Moni à post vers l'API</param>
        /// <returns>Le moni POST (null si erreur)</returns>
        public static async Task<Moni> PostMoni(Moni moni)
        {
            using HttpClient client = new HttpClient();
            try
            {
                string jsonData = JsonConvert.SerializeObject(moni);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // POST
                HttpResponseMessage res = await client.PostAsync("http://raspberry:5000/moni", content);

                if(res.IsSuccessStatusCode)
                {
                    return moni;
                }
                else
                {
                    var errorResponse = await res.Content.ReadAsStringAsync();
                    MessageBox.Show(errorResponse);
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        /// <summary>
        /// GET tous les comptes en banque d'un Moni
        /// </summary>
        /// <param name="id">Id du Moni</param>
        /// <returns></returns>
        public static async Task<List<BankAccount>> GetMoniAccounts(int id)
        {
            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage res = await client.GetAsync($"http://raspberry:5000/moni/{id}/accounts");
                if (res.IsSuccessStatusCode)
                {
                    List<BankAccount> accounts = await res.Content.ReadFromJsonAsync<List<BankAccount>>();
                    return accounts;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }



        public static async Task<List<Transaction>> GetAccountTransactions(int accountId)
        {
            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage res = await client.GetAsync($"http://raspberry:5000/account/{accountId}/transactions");
                if (res.IsSuccessStatusCode)
                {
                    List<Transaction> transactions = await res.Content.ReadFromJsonAsync<List<Transaction>>();
                    return transactions;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

    }
}
