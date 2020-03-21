import React, { Component } from 'react';
import { connect } from 'react-redux';

class Post extends Component {
  render() {
    const post = this.props.post ? (
      <div className="text-center m-auto max-w-sm rounded overflow-hidden shadow-lg px-6 py-8">
        <div>
          <span className="font-bold text-xl mb-2">
            {this.props.post.title}
          </span>
          <p className="text-gray-700 text-base">{this.props.post.body}</p>
        </div>
      </div>
    ) : (
      <div>Loading post...</div>
    );
    return <div className="text-gray-700">{post}</div>;
  }
}
const mapStateToProps = (state, ownProps) => {
  let id = ownProps.match.params.post_id;
  return {
    post: state.posts.find((post) => post.id === id),
  };
};
export default connect(mapStateToProps)(Post);
