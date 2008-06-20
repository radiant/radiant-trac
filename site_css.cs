<?cs
##################################################################
# Site CSS - Place custom CSS, including overriding styles here.
?>
body {
  background: #141414;
  color: #ccc;
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
  font-size: 85%;
  margin: 0;
  padding: 0;
}
:link, :visited {
  color: #f93;
  border-bottom: 0;
  text-decoration: underline;
}
:link:hover, :visited:hover {
  background: none;
  color: #f93;
  text-decoration: none;
}
h1, h2, h3, h4, h5, h6, strong {
  color: white;
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
}
h1 {
  font-size: 200%;
  margin-bottom: .75em;
} 
h2 {
  background: none;
  border-bottom: 2px solid #666;
  margin-top: 1.5em;
}
hr {
  display: none;
}
#site-links {
  background-color: #141414;
  padding: 1em;
  padding-left: 30px;
  padding-right: 30px;
  text-align: right;
}
#site-links a, #site-links strong {
  margin-left: 1em;
  padding: 1em;
  padding-left: .5em;
  padding-right: .5em;
}
#site-links strong a {
  color: white;
  padding: 0;
  margin: 0;
}
#site-links a {
  color: #c1c1c1;
  text-decoration: none;
}
#site-links a:hover {
  color: #f93;
  text-decoration: underline;
}
#site-links .separator {
  display: none;
}
#banner, #mainnav, #mainnav ul {
  background: #272727;
}
#banner {
  padding: 16px;
  padding-left: 30px
  pading-right: 30px;
  padding-bottom: 15px;
  margin: 0;
}
#logo {
  padding-left: 9px;
}
#metanav ul {
  font-size: 90%;
  margin-right: -7px;
}
#metanav ul li {
  border-right: 0;
}
#mainnav {
  background-color: #444;
  padding: 4px;
  padding-right: 11px;
  margin: 0;
  border: 0;
}
#mainnav ul {
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
  font-size: 140%;
  background: none;
  padding-top: 4px;
  padding-bottom: 4px;
}
#mainnav :link, #mainnav :visited {
  background: none;
  border: 0;
  color: #ccc;
  padding: 10px;
  padding-top: 4px;
  padding-bottom: 4px;
  text-decoration: none;
}
#mainnav :link:hover, #mainnav :visited:hover {
  background: none;
  border: 0;
  color: #f93;
  text-decoration: underline;
}
#mainnav .active :link, #mainnav .active :visited {
  background: none;
  border-right: 0;
}
#mainnav .active :link:hover, #mainnav .active :visited:hover {
  border-right: 0;
}
#main {
  background-color: #333; 
  padding-top: 15px;
  padding-left: 30px;
  padding-right: 30px;
}
#ctxtnav {
  margin-right: -15px;
}
#ctxtnav ul {
  font-size: 90%;
}
#ctxtnav li {
  border-right: 0;
}
#content {
  font-size: 110%;
  padding-top: 10px;
}
#footer {
  background: #272727;
  border-top: 0;
  font-size: 80%;
  padding: 15px;
}
#footer p.left {
  border: 0;
  padding-left: 0;
}
#foot {
  color: #aaa;
  padding: 15px;
  padding-left: 30px;
  padding-right: 30px;
}
#prefs {
  background-color: #444;
  border: 0;
  font-size: 90%;
}
table.listing {
  font-size: 100%;
}
table.listing thead {
  background: #272727;
}
table.listing thead th {
 border: 1px solid #333;
 border-bottom-color: #333;
}
table.listing tbody td, table.listing tbody th {
 border: 1px solid #333;
}
table.listing tbody tr { border-top: 1px solid #333; }
table.listing tbody tr.even { background-color: #444; }
table.listing tbody tr.odd { background-color: #444; }
table.listing tbody tr:hover { background: #555 !important }
pre.wiki, pre.literal-block {
  background-color: #222;
  border: 0;
}
.wiki-toc {
  background: #444;
  border: 0;
}
.wiki-toc .active {
  background: #333;
}
.timeline dl {
  font-size: 110%;
}
.timeline dt :link, .timeline dt :visited, .timeline dt :link:hover, .timeline dt :visited:hover {
  background: 3px 3px no-repeat;
  color: white;
  padding-top: 2px;
  text-decoration: none;
}
.timeline dt :link:hover, .timeline dt :visited:hover {
  background-color: #444;
}
.timeline dt :link em, .timeline dt :visited em {
  border-bottom: 0;
  color: #f93;
  padding-left: 0;
  padding-right: 0;
}
.timeline dt :link:hover em, .timeline dt :visited:hover em {
  color: #f93;
  text-decoration: underline;
}
.timeline dt .time {
  color: #ccc;
}
.timeline dd {
  color: #ccc;
}
.milestones .info h2 {
  background: none;
  border-bottom: 2px solid #666;
}
.milestones .info h2 :link, .milestones .info h2 :visited {
  color: white;
  text-decoration: none;
}
.milestones .info h2 :link:hover, .milestones .info h2 :visited:hover {
  background: #444;
  color: white;
}
.milestones .info h2 :link em, .milestones .info h2 :visited em, .milestones .info h2 link:hover em, .milestones .info h2 :visited:hover em {
  color: #f93 !important;
}
.milestones .info .date {
  color: #ccc;
}
.browser h1 :link, .browser h1 :visited {
  color: #f93;
  text-decoration: none;
}
.browser h1 :link:hover, .browser h1 :visited:hover {
  text-decoration: underline;
}
.browser h1 .first:link, .browser h1 .first:visited {
  color: #ccc;
}
.browser table.code {
  background-color: #444;
  color: #333;
}
.browser #preview, .diff .entries li {
  background-color: #666;
  border: 1px solid #666;
  color: #ccc;
}
.diff .entries li :link, .diff .entries li :visited {
  color: #f93;
}
.browser #info, .attachment #info {
  background: none;
  border: 0;
}
.browser #info th {
  padding-left: 0;
  padding-bottom: 1em;
}
.browser #preview tbody th, .diff table.inline tbody th {
  background-color: #e5e5e5;
}
.diff table.inline {
  color: black;
}
#ticket {
  background-color: #555;
  border: 0;
}
#ticket .date {
  background-color: #555;
  color: #ccc;
  padding-left: 1em;
}
#ticket h3.status {
  color: white;
}
#ticket table.properties {
  border-top: 1px solid #CCCCCC;
}
#ticket table.properties th {
  color: white;
}
#ticket .description h3 {
  color: #CCCCCC;
  border-bottom: 1px solid #CCCCCC;
}
#changelog, #attachments {
  border: 0;
  padding: 0;
  margin-bottom: 2em;
  margin-top: 1em;
}
.tabs li li.active {
  background-color: #ccc;
  color: #333;
}
.plugin, .plugin h3 {
  color: #333;
}
table.listing thead th {
  color: #fff;
}
form.addnew {
  margin: 0 0 4em;
}