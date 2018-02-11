using Manulife.SearchEngine.Model;
using Manulife.SearchEngine.Dao;
using System.Collections.Generic;

namespace Manulife.SearchEngine.Service
{
    public class ArticleService
    {
        private static ArticleService m_Instance = null;
        public static ArticleService Instance
        {
            get
            {
                if (m_Instance == null)
                    m_Instance = new ArticleService();
                return m_Instance;
            }
        }
        public Article Add(Article Article)
        {
            return new ArticleDao().Add(Article);
        }

        public int DeleteById(long id)
        {
            return new ArticleDao().DeleteById(id);
        }

        public int Delete(Article Article)
        {
            return new ArticleDao().Delete(Article);
        }

        public int Update(Article Article)
        {
            return new ArticleDao().Update(Article);
        }

        public Article GetById(long id)
        {
            return new ArticleDao().GetById(id);
        }

        public int GetTotalCount()
        {
            return new ArticleDao().GetTotalCount();
        }

        public IEnumerable<Article> GetPagedData(int minrownum, int maxrownum)
        {
            return new ArticleDao().GetPagedData(minrownum, maxrownum);
        }

        public IEnumerable<Article> GetAll()
        {
            return new ArticleDao().GetAll();
        }
    }
}
