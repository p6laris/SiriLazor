/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.{razor,html,cshtml}"],
  theme: {
      extend: {
          fontFamily: {
              'inter': "Inter"
          }
      },
  },
  plugins: [],
}

