using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using System.Collections;

namespace C17_Ex02_Opal_308345438_Liran_201392131
{
    public class PostsIterator : IEnumerable<Post>
    {
        private readonly ICollection<Post> m_Posts;

        public Func<Post, bool> Test { get; set; }

        public PostsIterator()
        {
            m_Posts = SingletonFacebookAppService.GetInstanceFacebookServices().FetchPosts();
        }

        public IEnumerator<Post> GetEnumerator()
        {
            foreach (Post post in m_Posts)
            {
                if(Test.Invoke(post))
                {
                    yield return post;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
       
    }
}
