using System;
using System.Collections;
using System.Collections.Generic;
namespace Task11
{
    public class RequestList: IEnumerator<ISaintNicholasRequest>, IEnumerable<ISaintNicholasRequest>
    {
        private List<ISaintNicholasRequest> requests;
        private int currentIndex = -1;
        private ISaintNicholasRequest currentRequest;

        public ISaintNicholasRequest Current => currentRequest; 
        object IEnumerator.Current => Current;




        public RequestList()
        {
            requests = new List<ISaintNicholasRequest>();
        }

        public void ParseList(string[] text)
        {
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    requests.Add(Request.Parse(text[i]));
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if(++currentIndex >= requests.Count)
                return false;
            else
                currentRequest = requests[currentIndex];

            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<ISaintNicholasRequest> GetEnumerator()
        {
            return requests.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
