using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace AdapterPattern
{
    /// <summary>
    /// 处理缓存数据问题：可以使用Adapter或者Proxy
    /// </summary>
    public interface ICacheStorage
    {
        void Remove(string key);
        void Store(string key, object data);
        T Retrieve<T>(string key);
    }

    /// <summary>
    /// 将一个类的接口转换成一个兼容的接口
    /// </summary>
    public class HttpContextCacheAdapter : ICacheStorage
    {

        public void Remove(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }

        public void Store(string key, object data)
        {
            HttpContext.Current.Cache.Insert(key, data);
        }

        public T Retrieve<T>(string key)
        {
            T t = (T)HttpContext.Current.Cache.Get(key);
            if (t == null)
                t = default(T);
            return t;
        }
    }

    public class NullObjectCacheAdapter : ICacheStorage
    {

        public void Remove(string key)
        {
            
        }

        public void Store(string key, object data)
        {
            
        }

        public T Retrieve<T>(string key)
        {
            return default(T); 
        }
    }
}
