const purgecss = require('@fullhuman/postcss-purgecss')({
  // Specify the paths to all of the template files in your project
  content: [
    './src/**/*.html',
    './src/**/*.js',
    './src/**/*.tsx',
    // etc.
  ],

  // Include any special characters you're using in this regular expression
  defaultExtractor: (content) => content.match(/[\w-/:]+(?<!:)/g) || [],
});

module.exports = {
<<<<<<< HEAD
    plugins: [
        require('tailwindcss'),
        require('autoprefixer'),
        ...process.env.NODE_ENV === 'development'
            ? [purgecss]
            : []
    ]
};
=======
  plugins: [
    require('tailwindcss'),
    require('autoprefixer'),
    ...(process.env.NODE_ENV !== 'development' ? [purgecss] : []),
  ],
};
>>>>>>> 588e1cf0e2150b8a8e7fa79c6b0f82f18efe850a
