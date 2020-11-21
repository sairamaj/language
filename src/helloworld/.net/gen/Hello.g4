grammar Hello;

r   : 'hello' ID;       // match keyword hello by identifier
ID  : [a-z]+;           // match lower case identifier
WS  : [ \t\r\n]+ -> skip;  // skip space, tab, new line 