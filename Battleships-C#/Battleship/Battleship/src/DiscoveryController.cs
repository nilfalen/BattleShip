 
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 u s i n g   S w i n G a m e S D K ;  
  
 / / /   < s u m m a r y >  
 / / /   T h e   b a t t l e   p h a s e   i s   h a n d l e d   b y   t h e   D i s c o v e r y C o n t r o l l e r .  
 / / /   < / s u m m a r y >  
 s t a t i c   c l a s s   D i s c o v e r y C o n t r o l l e r  
 {  
  
 	 / / /   < s u m m a r y >  
 	 / / /   H a n d l e s   i n p u t   d u r i n g   t h e   d i s c o v e r y   p h a s e   o f   t h e   g a m e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s >  
 	 / / /   E s c a p e   o p e n s   t h e   g a m e   m e n u .   C l i c k i n g   t h e   m o u s e   w i l l  
 	 / / /   a t t a c k   a   l o c a t i o n .  
 	 / / /   < / r e m a r k s >  
 	 p u b l i c   s t a t i c   v o i d   H a n d l e D i s c o v e r y I n p u t ( )  
 	 {  
 	 	 i f   ( S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ E S C A P E ) )   {  
 	 	 	 A d d N e w S t a t e ( G a m e S t a t e . V i e w i n g G a m e M e n u ) ;  
 	 	 }  
  
 	 	 i f   ( S w i n G a m e . M o u s e C l i c k e d ( M o u s e B u t t o n . L e f t B u t t o n ) )   {  
 	 	 	 D o A t t a c k ( ) ;  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   A t t a c k   t h e   l o c a t i o n   t h a t   t h e   m o u s e   i f   o v e r .  
 	 / / /   < / s u m m a r y >  
 	 p r i v a t e   s t a t i c   v o i d   D o A t t a c k ( )  
 	 {  
 	 	 P o i n t 2 D   m o u s e   =   d e f a u l t ( P o i n t 2 D ) ;  
  
 	 	 m o u s e   =   S w i n G a m e . M o u s e P o s i t i o n ( ) ;  
  
 	 	 / / C a l c u l a t e   t h e   r o w / c o l   c l i c k e d  
 	 	 i n t   r o w   =   0 ;  
 	 	 i n t   c o l   =   0 ;  
 	 	 r o w   =   C o n v e r t . T o I n t 3 2 ( M a t h . F l o o r ( ( m o u s e . Y   -   F I E L D _ T O P )   /   ( C E L L _ H E I G H T   +   C E L L _ G A P ) ) ) ;  
 	 	 c o l   =   C o n v e r t . T o I n t 3 2 ( M a t h . F l o o r ( ( m o u s e . X   -   F I E L D _ L E F T )   /   ( C E L L _ W I D T H   +   C E L L _ G A P ) ) ) ;  
  
 	 	 i f   ( r o w   > =   0   &   r o w   <   H u m a n P l a y e r . E n e m y G r i d . H e i g h t )   {  
 	 	 	 i f   ( c o l   > =   0   &   c o l   <   H u m a n P l a y e r . E n e m y G r i d . W i d t h )   {  
 	 	 	 	 A t t a c k ( r o w ,   c o l ) ;  
 	 	 	 }  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   D r a w s   t h e   g a m e   d u r i n g   t h e   a t t a c k   p h a s e .  
 	 / / /   < / s u m m a r y > s  
 	 p u b l i c   s t a t i c   v o i d   D r a w D i s c o v e r y ( )  
 	 {  
 	 	 c o n s t   i n t   S C O R E S _ L E F T   =   1 7 2 ;  
 	 	 c o n s t   i n t   S H O T S _ T O P   =   1 5 7 ;  
 	 	 c o n s t   i n t   H I T S _ T O P   =   2 0 6 ;  
 	 	 c o n s t   i n t   S P L A S H _ T O P   =   2 5 6 ;  
  
 	 	 i f   ( ( S w i n G a m e . K e y D o w n ( K e y C o d e . V K _ L S H I F T )   |   S w i n G a m e . K e y D o w n ( K e y C o d e . V K _ R S H I F T ) )   &   S w i n G a m e . K e y D o w n ( K e y C o d e . V K _ C ) )   {  
 	 	 	 D r a w F i e l d ( H u m a n P l a y e r . E n e m y G r i d ,   C o m p u t e r P l a y e r ,   t r u e ) ;  
 	 	 }   e l s e   {  
 	 	 	 D r a w F i e l d ( H u m a n P l a y e r . E n e m y G r i d ,   C o m p u t e r P l a y e r ,   f a l s e ) ;  
 	 	 }  
  
 	 	 D r a w S m a l l F i e l d ( H u m a n P l a y e r . P l a y e r G r i d ,   H u m a n P l a y e r ) ;  
 	 	 D r a w M e s s a g e ( ) ;  
  
 	 	 S w i n G a m e . D r a w T e x t ( H u m a n P l a y e r . S h o t s . T o S t r i n g ( ) ,   C o l o r . W h i t e ,   G a m e F o n t ( " M e n u " ) ,   S C O R E S _ L E F T ,   S H O T S _ T O P ) ;  
 	 	 S w i n G a m e . D r a w T e x t ( H u m a n P l a y e r . H i t s . T o S t r i n g ( ) ,   C o l o r . W h i t e ,   G a m e F o n t ( " M e n u " ) ,   S C O R E S _ L E F T ,   H I T S _ T O P ) ;  
 	 	 S w i n G a m e . D r a w T e x t ( H u m a n P l a y e r . M i s s e d . T o S t r i n g ( ) ,   C o l o r . W h i t e ,   G a m e F o n t ( " M e n u " ) ,   S C O R E S _ L E F T ,   S P L A S H _ T O P ) ;  
 	 }  
  
 } 