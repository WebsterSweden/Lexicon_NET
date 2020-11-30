# HTML

*Your assignment is to build a basic HTML page structure, for use in later exercises. Don't focus at all on styling at this point – only make the HTML elements and their contents. Refer to W3Schools and Pluralsight for information on how to implement the required features.*

## Required Features:
* The page should be encoded using the UTF-8 character set
* A page title, defined in the head element.
* A header element containing a heading (h1) with the page name. It should also have a nav element with an unordered list of at least 3 links
* A container element for the main content of the page, containing a heading (h2), a paragraph of text and two article elements. Each should have filler text - at least 2 paragraphs each. One should have an image (use http://lorempixel.com/)
* A aside element, containing a heading (h2) and an unordered list of nations, each list item containing an ordered list of the nation's three biggest cities
* A footer element, containing a copyright symbol and your name

### Resources:
* https://www.w3schools.com/ - General HTML reference
* https://lipsum.com/ - Filler Text
* http://lorempixel.com/ - Placeholder Images
* https://app.pluralsight.com/library/courses/front-end-web-app-html5-javascript-css/table-of-contents (The first two chapters are relevant for this week)

### Subjects Covered:

### Basic HTML
* Containers<br />
    * Header, Footer, Nav, Section, Article, Aside<br />
* Lists<br />
    * Ordered, Unordered<br />
* Text<br />
    * Span, Paragraph<br />
* Images<br />
* Headings

<hr>

# CSS

*In this assignment, you will take a complete HTML page (the one you made in the HTML fundamentals exercise), and style it using CSS. You are not allowed to make modifications to the page – it should be unchanged, with the possible exception of adding classes or ids to elements.*

## Required Features:
* All text on the page should use a sans-serif font family.
* The page should be 1024 pixels wide, and be centered on the page, with equal margins to the left and right.
* Give the page the appearance of the example placed in picture below, using only your own CSS code.

![](https://github.com/WebsterSweden/Lexicon_NET/blob/master/6_HTML_and_CSS/images/html-css-1.png)

*(The gray boxes show where elements should be positioned – you do not need them to appear as gray boxes on the page)*

### Optional:
* The second paragraph of the first article element should be written in bold text, with a blue text colour.
* In the unordered list in the side content, items should appear in alternating colours (green and red, as a suggestion).

### Code Requirements:
* All the CSS code should come from the same file, and be linked into the HTML file through a link tag – there should be no style tags or style attributes in the HTML file at all.

### Resources:
* https://www.w3schools.com/css/default.asp
* https://app.pluralsight.com/library/courses/front-end-web-app-html5-javascript-css/table-of-contents
* https://app.pluralsight.com/library/courses/css-intro/table-of-contents

### Subjects Covered:
* CSS
    * Selectors
    * Styling Rules

<hr>

# Bootstrap

*This assignment is meant as an introduction to the use of Twitter Bootstrap – a framework for CSS that is used by many web developers today. You will make the page entirely from scratch, using Bootstrap classes combined with your own CSS rules to style your page.*

## Required Features:
* A menu bar, fixed to the top of the page, containing
    * A logo image (use http://lorempixel.com/ or find your own).
    * Links to different parts of the website.
* A content section of the page with more than one article in a single line, separated into columns.
* A carousel element containing at least three images.
* A sidebar menu to the main content section, using the Stacked Pills component for the menu items.
* A contact form with fields for name, email-address, telephone number and a message. It should have a button to submit the form (using the "btn-success" class), and a button to reset the form's fields (using the "btn-danger" class).
* A footer, fixed to the bottom of the page, with a copyright notice using glyphicons, and a link returning you to the top of the page.

### Optional:
* Add one more slide to the carousel, moving the contact form into it.
* Change the list of links in the menu bar to a dropdown.
* Make the menu bar links align to the right side of the page, while the logo and name aligns to the left side of the page

### Code Requirements:
* Bootstrap must be included, with dependencies.
* A bootstrap theme must be used.

### Resources:
* https://getbootstrap.com/ - Bootstrap download page
* https://bootswatch.com/ - Bootstrap theme library
* http://lorempixel.com/ - Placeholder images
* https://app.pluralsight.com/library/courses/bootstrap-3/table-of-contents - PluralSight E-learning material
* https://app.pluralsight.com/library/courses/responsive-websites-bootstrap3/table-of-contents

### Expected Duration: 1-2 days

### Subjects Covered:
Bootstrap
* Themes
* Layout Grid
* Components:
    * Buttons
    * Navbars
    * Carousels
    * Forms
    * Dropdowns
    * Nav Pills
    * Glyphicons
    * Element alignment
