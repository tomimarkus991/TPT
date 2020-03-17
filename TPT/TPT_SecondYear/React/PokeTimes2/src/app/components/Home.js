import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';
import Pokeball from '../images/pokeball.png';

class Home extends Component {
  state = {
    posts: [],
  };
  componentDidMount() {
    axios.get('https://jsonplaceholder.typicode.com/posts').then((res) => {
      console.log(res);
      this.setState({
        posts: res.data.slice(0, 10),
      });
    });
  }
  render() {
    const { posts } = this.state;
    const postList = posts.length ? (
      posts.map((post) => {
        return (
          <div
            className="overflow-hidden relative text-center mr-auto ml-auto max-w-md rounded shadow-lg px-16 py-8"
            key={post.id}>
            <img
              className="absolute opacity-75 mt-1 -ml-40"
              src={Pokeball}
              alt="Pokeball image"
            />
            <div>
              <Link to={'/' + post.id}>
                <span className="font-bold text-xl mb-2">{post.title}</span>
              </Link>
              <p className="text-gray-700 text-base">{post.body}</p>
            </div>
          </div>
        );
      })
    ) : (
      <div>No posts yet</div>
    );
    return (
      <div className="text-center">
        <h1>Home</h1>
        {postList}
      </div>
    );
  }
}

export default Home;
