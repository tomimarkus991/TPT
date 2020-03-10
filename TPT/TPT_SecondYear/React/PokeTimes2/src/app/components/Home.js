import React, { Component } from 'react';
import axios from "axios";

class Home extends Component {
  state = {
    posts: []
  };
  componentDidMount() {
    axios.get("https://jsonplaceholder.typicode.com/posts")
      .then(res => {
        console.log(res);
        this.setState({
          posts: res.data.slice(0, 10)
        });
      });
  }
  render() {
    const { posts } = this.state;
    const postList = posts.length ? (
      posts.map(post => {
        return (
          <div className="text-center m-auto max-w-sm rounded overflow-hidden shadow-lg px-6 py-8" key={post.id}>
            <div>
              <span className="font-bold text-xl mb-2">{post.title}</span>
              <p className="text-gray-700 text-base">{post.body}</p>
            </div>
          </div>
        );
      })
    ) : (
        <div>No posts yet</div>
      );
    return (
      <div className="text-center" >
        <h1>Home</h1>
        <p>See on meie homepahe</p>
        {postList}
      </div>
    );
  }
}

export default Home;
