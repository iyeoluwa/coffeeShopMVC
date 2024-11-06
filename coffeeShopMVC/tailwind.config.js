/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Pages/**/*.cshtml',
    './Views/**/*.cshtml'
  ],
  theme: {
    extend: {
      spacing: {
        '72': '18rem',
        '84': '21rem',
        '96': '24rem',
        '100':'28rem',
        '128':'32rem',
        '164':'48rem'
      },
      colors: {
        'primary': '#1da1f2',
        'secondary': '#14171a',
        'coffee-brown-navbar':'#4A4947',
        'coffee-brown-reddish':'#7c2b18',
        'coffee-wendge':'#5c4d4a',
        'choco-gold':'#d4a017',
        'coffee-bean-brown':'#5a3f2d',
        'chochi-brown':'#2e2827'
      },
    },
  },
  plugins: [],
}

