import React, { Component } from 'react';
import axios from 'axios';

class Post extends Component {
  state = {
    post: null,
  };
  componentDidMount() {
    console.log('component monted man');
    let id = this.props.match.params.id;
    axios
      .get('https://jsonplaceholder.typicode.com/posts/' + id)
      .then((res) => {
        this.setState({
          post: res.data,
        });
      });
  }
  render() {
    const post = this.state.post ? (
      <div className="text-center m-auto max-w-sm rounded overflow-hidden shadow-lg px-6 py-8">
        <div>
          <span className="font-bold text-xl mb-2">
            {this.state.post.title}
          </span>
          <p className="text-gray-700 text-base">{this.state.post.body}</p>
        </div>
      </div>
    ) : (
      <div>Loading post...</div>
    );
    return <div className="text-gray-700">{post}</div>;
  }
}
export default Post;
