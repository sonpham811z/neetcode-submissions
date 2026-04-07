public class Twitter {

    public int timeStamp = 0;
    private Dictionary<int, HashSet<int>> followees;
    
    private Dictionary<int, List<(int timeStamp, int tweetId)>> tweets;

    public Twitter() {
        followees = new Dictionary<int, HashSet<int>>();
        tweets = new Dictionary<int, List<(int time, int tweetId)>>();
    }
    
    public void PostTweet(int userId, int tweetId) {
        if(!tweets.ContainsKey(userId))
            tweets[userId] = new List<(int, int)>();
        tweets[userId].Add((timeStamp++, tweetId));
    }
    
    public List<int> GetNewsFeed(int userId) {
        var pq = new PriorityQueue<int, int>();

        var usersToFetch = new HashSet<int> {userId};
        if(followees.ContainsKey(userId)) {
            usersToFetch.UnionWith(followees[userId]);
        }

        foreach(var uId in usersToFetch) {
            if(tweets.ContainsKey(uId))
            {
                var post = tweets[uId];

                for (int i = 0; i < post.Count; i++)
                {
                    pq.Enqueue(post[i].tweetId, post[i].timeStamp);
                    if(pq.Count > 10)
                        pq.Dequeue();
                }
            }
        }

        var res = new List<int>();
        while(pq.Count>0)
            res.Add(pq.Dequeue());
        res.Reverse();
        return res;
    }
    
    public void Follow(int followerId, int followeeId) {
        if(!followees.ContainsKey(followerId)) {
            followees[followerId] = new HashSet<int>();
        }
        followees[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if (followees.ContainsKey(followerId)) {
            followees[followerId].Remove(followeeId);
        }
    }
}
