 
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 u s i n g   S y s t e m . I O ;  
 u s i n g   S w i n G a m e S D K ;  
  
 / / /   < s u m m a r y >  
 / / /   C o n t r o l s   d i s p l a y i n g   a n d   c o l l e c t i n g   h i g h   s c o r e   d a t a .  
 / / /   < / s u m m a r y >  
 / / /   < r e m a r k s >  
 / / /   D a t a   i s   s a v e d   t o   a   f i l e .  
 / / /   < / r e m a r k s >  
 s t a t i c   c l a s s   H i g h S c o r e C o n t r o l l e r  
 {  
 	 p r i v a t e   c o n s t   i n t   N A M E _ W I D T H   =   3 ;  
  
 	 p r i v a t e   c o n s t   i n t   S C O R E S _ L E F T   =   4 9 0 ;  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   s c o r e   s t r u c t u r e   i s   u s e d   t o   k e e p   t h e   n a m e   a n d  
 	 / / /   s c o r e   o f   t h e   t o p   p l a y e r s   t o g e t h e r .  
 	 / / /   < / s u m m a r y >  
 	 p r i v a t e   s t r u c t   S c o r e   :   I C o m p a r a b l e  
 	 {  
 	 	 p u b l i c   s t r i n g   N a m e ;  
  
 	 	 p u b l i c   i n t   V a l u e ;  
 	 	 / / /   < s u m m a r y >  
 	 	 / / /   A l l o w s   s c o r e s   t o   b e   c o m p a r e d   t o   f a c i l i t a t e   s o r t i n g  
 	 	 / / /   < / s u m m a r y >  
 	 	 / / /   < p a r a m   n a m e = " o b j " > t h e   o b j e c t   t o   c o m p a r e   t o < / p a r a m >  
 	 	 / / /   < r e t u r n s > a   v a l u e   t h a t   i n d i c a t e s   t h e   s o r t   o r d e r < / r e t u r n s >  
 	 	 p u b l i c   i n t   C o m p a r e T o ( o b j e c t   o b j )  
 	 	 {  
 	 	 	 i f   ( o b j   i s   S c o r e )   {  
 	 	 	 	 S c o r e   o t h e r   =   ( S c o r e ) o b j ;  
  
 	 	 	 	 r e t u r n   o t h e r . V a l u e   -   t h i s . V a l u e ;  
 	 	 	 }   e l s e   {  
 	 	 	 	 r e t u r n   0 ;  
 	 	 	 }  
 	 	 }  
 	 }  
  
  
 	 p r i v a t e   s t a t i c   L i s t < S c o r e >   _ S c o r e s   =   n e w   L i s t < S c o r e > ( ) ;  
 	 / / /   < s u m m a r y >  
 	 / / /   L o a d s   t h e   s c o r e s   f r o m   t h e   h i g h s c o r e s   t e x t   f i l e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s >  
 	 / / /   T h e   f o r m a t   i s  
 	 / / /   #   o f   s c o r e s  
 	 / / /   N N N S S S  
 	 / / /    
 	 / / /   W h e r e   N N N   i s   t h e   n a m e   a n d   S S S   i s   t h e   s c o r e  
 	 / / /   < / r e m a r k s >  
 	 p r i v a t e   s t a t i c   v o i d   L o a d S c o r e s ( )  
 	 {  
 	 	 s t r i n g   f i l e n a m e   =   n u l l ;  
 	 	 f i l e n a m e   =   S w i n G a m e . P a t h T o R e s o u r c e ( " h i g h s c o r e s . t x t " ) ;  
  
 	 	 S t r e a m R e a d e r   i n p u t   =   d e f a u l t ( S t r e a m R e a d e r ) ;  
 	 	 i n p u t   =   n e w   S t r e a m R e a d e r ( f i l e n a m e ) ;  
  
 	 	 / / R e a d   i n   t h e   #   o f   s c o r e s  
 	 	 i n t   n u m S c o r e s   =   0 ;  
 	 	 n u m S c o r e s   =   C o n v e r t . T o I n t 3 2 ( i n p u t . R e a d L i n e ( ) ) ;  
  
 	 	 _ S c o r e s . C l e a r ( ) ;  
  
 	 	 i n t   i   =   0 ;  
  
 	 	 f o r   ( i   =   1 ;   i   < =   n u m S c o r e s ;   i + + )   {  
 	 	 	 S c o r e   s   =   d e f a u l t ( S c o r e ) ;  
 	 	 	 s t r i n g   l i n e   =   n u l l ;  
  
 	 	 	 l i n e   =   i n p u t . R e a d L i n e ( ) ;  
  
 	 	 	 s . N a m e   =   l i n e . S u b s t r i n g ( 0 ,   N A M E _ W I D T H ) ;  
 	 	 	 s . V a l u e   =   C o n v e r t . T o I n t 3 2 ( l i n e . S u b s t r i n g ( N A M E _ W I D T H ) ) ;  
 	 	 	 _ S c o r e s . A d d ( s ) ;  
 	 	 }  
 	 	 i n p u t . C l o s e ( ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S a v e s   t h e   s c o r e s   b a c k   t o   t h e   h i g h s c o r e s   t e x t   f i l e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s >  
 	 / / /   T h e   f o r m a t   i s  
 	 / / /   #   o f   s c o r e s  
 	 / / /   N N N S S S  
 	 / / /    
 	 / / /   W h e r e   N N N   i s   t h e   n a m e   a n d   S S S   i s   t h e   s c o r e  
 	 / / /   < / r e m a r k s >  
 	 p r i v a t e   s t a t i c   v o i d   S a v e S c o r e s ( )  
 	 {  
 	 	 s t r i n g   f i l e n a m e   =   n u l l ;  
 	 	 f i l e n a m e   =   S w i n G a m e . P a t h T o R e s o u r c e ( " h i g h s c o r e s . t x t " ) ;  
  
 	 	 S t r e a m W r i t e r   o u t p u t   =   d e f a u l t ( S t r e a m W r i t e r ) ;  
 	 	 o u t p u t   =   n e w   S t r e a m W r i t e r ( f i l e n a m e ) ;  
  
 	 	 o u t p u t . W r i t e L i n e ( _ S c o r e s . C o u n t ) ;  
  
 	 	 f o r e a c h   ( S c o r e   s   i n   _ S c o r e s )   {  
 	 	 	 o u t p u t . W r i t e L i n e ( s . N a m e   +   s . V a l u e ) ;  
 	 	 }  
  
 	 	 o u t p u t . C l o s e ( ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   D r a w s   t h e   h i g h   s c o r e s   t o   t h e   s c r e e n .  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   s t a t i c   v o i d   D r a w H i g h S c o r e s ( )  
 	 {  
 	 	 c o n s t   i n t   S C O R E S _ H E A D I N G   =   4 0 ;  
 	 	 c o n s t   i n t   S C O R E S _ T O P   =   8 0 ;  
 	 	 c o n s t   i n t   S C O R E _ G A P   =   3 0 ;  
  
 	 	 i f   ( _ S c o r e s . C o u n t   = =   0 )  
 	 	 	 L o a d S c o r e s ( ) ;  
  
 	 	 S w i n G a m e . D r a w T e x t ( "       H i g h   S c o r e s       " ,   C o l o r . W h i t e ,   G a m e F o n t ( " C o u r i e r " ) ,   S C O R E S _ L E F T ,   S C O R E S _ H E A D I N G ) ;  
  
 	 	 / / F o r   a l l   o f   t h e   s c o r e s  
 	 	 i n t   i   =   0 ;  
 	 	 f o r   ( i   =   0 ;   i   < =   _ S c o r e s . C o u n t   -   1 ;   i + + )   {  
 	 	 	 S c o r e   s   =   d e f a u l t ( S c o r e ) ;  
  
 	 	 	 s   =   _ S c o r e s . I t e m ( i ) ;  
  
 	 	 	 / / f o r   s c o r e s   1   -   9   u s e   0 1   -   0 9  
 	 	 	 i f   ( i   <   9 )   {  
 	 	 	 	 S w i n G a m e . D r a w T e x t ( "   "   +   ( i   +   1 )   +   " :       "   +   s . N a m e   +   "       "   +   s . V a l u e ,   C o l o r . W h i t e ,   G a m e F o n t ( " C o u r i e r " ) ,   S C O R E S _ L E F T ,   S C O R E S _ T O P   +   i   *   S C O R E _ G A P ) ;  
 	 	 	 }   e l s e   {  
 	 	 	 	 S w i n G a m e . D r a w T e x t ( i   +   1   +   " :       "   +   s . N a m e   +   "       "   +   s . V a l u e ,   C o l o r . W h i t e ,   G a m e F o n t ( " C o u r i e r " ) ,   S C O R E S _ L E F T ,   S C O R E S _ T O P   +   i   *   S C O R E _ G A P ) ;  
 	 	 	 }  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   H a n d l e s   t h e   u s e r   i n p u t   d u r i n g   t h e   t o p   s c o r e   s c r e e n .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s > < / r e m a r k s >  
 	 p u b l i c   s t a t i c   v o i d   H a n d l e H i g h S c o r e I n p u t ( )  
 	 {  
 	 	 i f   ( S w i n G a m e . M o u s e C l i c k e d ( M o u s e B u t t o n . L e f t B u t t o n )   | |   S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ E S C A P E )   | |   S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ R E T U R N ) )   {  
 	 	 	 E n d C u r r e n t S t a t e ( ) ;  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   R e a d   t h e   u s e r ' s   n a m e   f o r   t h e i r   h i g h s S w i n G a m e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " v a l u e " > t h e   p l a y e r ' s   s S w i n G a m e . < / p a r a m >  
 	 / / /   < r e m a r k s >  
 	 / / /   T h i s   v e r i f i e s   i f   t h e   s c o r e   i s   a   h i g h s S w i n G a m e .  
 	 / / /   < / r e m a r k s >  
 	 p u b l i c   s t a t i c   v o i d   R e a d H i g h S c o r e ( i n t   v a l u e )  
 	 {  
 	 	 c o n s t   i n t   E N T R Y _ T O P   =   5 0 0 ;  
  
 	 	 i f   ( _ S c o r e s . C o u n t   = =   0 )  
 	 	 	 L o a d S c o r e s ( ) ;  
  
 	 	 / / i s   i t   a   h i g h   s c o r e  
 	 	 i f   ( v a l u e   >   _ S c o r e s . I t e m ( _ S c o r e s . C o u n t   -   1 ) . V a l u e )   {  
 	 	 	 S c o r e   s   =   n e w   S c o r e ( ) ;  
 	 	 	 s . V a l u e   =   v a l u e ;  
  
 	 	 	 A d d N e w S t a t e ( G a m e S t a t e . V i e w i n g H i g h S c o r e s ) ;  
  
 	 	 	 i n t   x   =   0 ;  
 	 	 	 x   =   S C O R E S _ L E F T   +   S w i n G a m e . T e x t W i d t h ( G a m e F o n t ( " C o u r i e r " ) ,   " N a m e :   " ) ;  
  
 	 	 	 S w i n G a m e . S t a r t R e a d i n g T e x t ( C o l o r . W h i t e ,   N A M E _ W I D T H ,   G a m e F o n t ( " C o u r i e r " ) ,   x ,   E N T R Y _ T O P ) ;  
  
 	 	 	 / / R e a d   t h e   t e x t   f r o m   t h e   u s e r  
 	 	 	 w h i l e   ( S w i n G a m e . R e a d i n g T e x t ( ) )   {  
 	 	 	 	 S w i n G a m e . P r o c e s s E v e n t s ( ) ;  
  
 	 	 	 	 D r a w B a c k g r o u n d ( ) ;  
 	 	 	 	 D r a w H i g h S c o r e s ( ) ;  
 	 	 	 	 S w i n G a m e . D r a w T e x t ( " N a m e :   " ,   C o l o r . W h i t e ,   G a m e F o n t ( " C o u r i e r " ) ,   S C O R E S _ L E F T ,   E N T R Y _ T O P ) ;  
 	 	 	 	 S w i n G a m e . R e f r e s h S c r e e n ( ) ;  
 	 	 	 }  
  
 	 	 	 s . N a m e   =   S w i n G a m e . T e x t R e a d A s A S C I I ( ) ;  
  
 	 	 	 i f   ( s . N a m e . L e n g t h   <   3 )   {  
 	 	 	 	 s . N a m e   =   s . N a m e   +   n e w   s t r i n g ( C o n v e r t . T o C h a r ( "   " ) ,   3   -   s . N a m e . L e n g t h ) ;  
 	 	 	 }  
  
 	 	 	 _ S c o r e s . R e m o v e A t ( _ S c o r e s . C o u n t   -   1 ) ;  
 	 	 	 _ S c o r e s . A d d ( s ) ;  
 	 	 	 _ S c o r e s . S o r t ( ) ;  
  
 	 	 	 E n d C u r r e n t S t a t e ( ) ;  
 	 	 }  
 	 }  
 } 