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
 / / /   T h e   D e p l o y m e n t C o n t r o l l e r   c o n t r o l s   t h e   p l a y e r s   a c t i o n s  
 / / /   d u r i n g   t h e   d e p l o y m e n t   p h a s e .  
 / / /   < / s u m m a r y >  
 s t a t i c   c l a s s   D e p l o y m e n t C o n t r o l l e r  
 {  
 	 p r i v a t e   c o n s t   i n t   S H I P S _ T O P   =   9 8 ;  
 	 p r i v a t e   c o n s t   i n t   S H I P S _ L E F T   =   2 0 ;  
 	 p r i v a t e   c o n s t   i n t   S H I P S _ H E I G H T   =   9 0 ;  
  
 	 p r i v a t e   c o n s t   i n t   S H I P S _ W I D T H   =   3 0 0 ;  
 	 p r i v a t e   c o n s t   i n t   T O P _ B U T T O N S _ T O P   =   7 2 ;  
  
 	 p r i v a t e   c o n s t   i n t   T O P _ B U T T O N S _ H E I G H T   =   4 6 ;  
 	 p r i v a t e   c o n s t   i n t   P L A Y _ B U T T O N _ L E F T   =   6 9 3 ;  
  
 	 p r i v a t e   c o n s t   i n t   P L A Y _ B U T T O N _ W I D T H   =   8 0 ;  
 	 p r i v a t e   c o n s t   i n t   U P _ D O W N _ B U T T O N _ L E F T   =   4 1 0 ;  
  
 	 p r i v a t e   c o n s t   i n t   L E F T _ R I G H T _ B U T T O N _ L E F T   =   3 5 0 ;  
 	 p r i v a t e   c o n s t   i n t   R A N D O M _ B U T T O N _ L E F T   =   5 4 7 ;  
  
 	 p r i v a t e   c o n s t   i n t   R A N D O M _ B U T T O N _ W I D T H   =   5 1 ;  
  
 	 p r i v a t e   c o n s t   i n t   D I R _ B U T T O N S _ W I D T H   =   4 7 ;  
  
 	 p r i v a t e   c o n s t   i n t   T E X T _ O F F S E T   =   5 ;  
 	 p r i v a t e   s t a t i c   D i r e c t i o n   _ c u r r e n t D i r e c t i o n   =   D i r e c t i o n . U p D o w n ;  
  
 	 p r i v a t e   s t a t i c   S h i p N a m e   _ s e l e c t e d S h i p   =   S h i p N a m e . T u g ;  
 	 / / /   < s u m m a r y >  
 	 / / /   H a n d l e s   u s e r   i n p u t   f o r   t h e   D e p l o y m e n t   p h a s e   o f   t h e   g a m e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s >  
 	 / / /   I n v o l v e s   s e l e c t i n g   t h e   s h i p s ,   d e l o y i n g   s h i p s ,   c h a n g i n g   t h e   d i r e c t i o n  
 	 / / /   o f   t h e   s h i p s   t o   a d d ,   r a n d o m i s i n g   d e p l o y m e n t ,   e n d   t h e n   e n d i n g  
 	 / / /   d e p l o y m e n t  
 	 / / /   < / r e m a r k s >  
 	 p u b l i c   s t a t i c   v o i d   H a n d l e D e p l o y m e n t I n p u t ( )  
 	 {  
 	 	 i f   ( S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ E S C A P E ) )   {  
 	 	 	 A d d N e w S t a t e ( G a m e S t a t e . V i e w i n g G a m e M e n u ) ;  
 	 	 }  
  
 	 	 i f   ( S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ U P )   |   S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ D O W N ) )   {  
 	 	 	 _ c u r r e n t D i r e c t i o n   =   D i r e c t i o n . U p D o w n ;  
 	 	 }  
 	 	 i f   ( S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ L E F T )   |   S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ R I G H T ) )   {  
 	 	 	 _ c u r r e n t D i r e c t i o n   =   D i r e c t i o n . L e f t R i g h t ;  
 	 	 }  
  
 	 	 i f   ( S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ R ) )   {  
 	 	 	 H u m a n P l a y e r . R a n d o m i z e D e p l o y m e n t ( ) ;  
 	 	 }  
  
 	 	 i f   ( S w i n G a m e . M o u s e C l i c k e d ( M o u s e B u t t o n . L e f t B u t t o n ) )   {  
 	 	 	 S h i p N a m e   s e l e c t e d   =   d e f a u l t ( S h i p N a m e ) ;  
 	 	 	 s e l e c t e d   =   G e t S h i p M o u s e I s O v e r ( ) ;  
 	 	 	 i f   ( s e l e c t e d   ! =   S h i p N a m e . N o n e )   {  
 	 	 	 	 _ s e l e c t e d S h i p   =   s e l e c t e d ;  
 	 	 	 }   e l s e   {  
 	 	 	 	 D o D e p l o y C l i c k ( ) ;  
 	 	 	 }  
  
 	 	 	 i f   ( H u m a n P l a y e r . R e a d y T o D e p l o y   &   I s M o u s e I n R e c t a n g l e ( P L A Y _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P ,   P L A Y _ B U T T O N _ W I D T H ,   T O P _ B U T T O N S _ H E I G H T ) )   {  
 	 	 	 	 E n d D e p l o y m e n t ( ) ;  
 	 	 	 }   e l s e   i f   ( I s M o u s e I n R e c t a n g l e ( U P _ D O W N _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P ,   D I R _ B U T T O N S _ W I D T H ,   T O P _ B U T T O N S _ H E I G H T ) )   {  
 	 	 	 	 _ c u r r e n t D i r e c t i o n   =   D i r e c t i o n . L e f t R i g h t ;  
 	 	 	 }   e l s e   i f   ( I s M o u s e I n R e c t a n g l e ( L E F T _ R I G H T _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P ,   D I R _ B U T T O N S _ W I D T H ,   T O P _ B U T T O N S _ H E I G H T ) )   {  
 	 	 	 	 _ c u r r e n t D i r e c t i o n   =   D i r e c t i o n . L e f t R i g h t ;  
 	 	 	 }   e l s e   i f   ( I s M o u s e I n R e c t a n g l e ( R A N D O M _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P ,   R A N D O M _ B U T T O N _ W I D T H ,   T O P _ B U T T O N S _ H E I G H T ) )   {  
 	 	 	 	 H u m a n P l a y e r . R a n d o m i z e D e p l o y m e n t ( ) ;  
 	 	 	 }  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   u s e r   h a s   c l i c k e d   s o m e w h e r e   o n   t h e   s c r e e n ,   c h e c k   i f   i t s   i s   a   d e p l o y m e n t   a n d   d e p l o y  
 	 / / /   t h e   c u r r e n t   s h i p   i f   t h a t   i s   t h e   c a s e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s >  
 	 / / /   I f   t h e   c l i c k   i s   i n   t h e   g r i d   i t   d e p l o y s   t o   t h e   s e l e c t e d   l o c a t i o n  
 	 / / /   w i t h   t h e   i n d i c a t e d   d i r e c t i o n  
 	 / / /   < / r e m a r k s >  
 	 p r i v a t e   s t a t i c   v o i d   D o D e p l o y C l i c k ( )  
 	 {  
 	 	 P o i n t 2 D   m o u s e   =   d e f a u l t ( P o i n t 2 D ) ;  
  
 	 	 m o u s e   =   S w i n G a m e . M o u s e P o s i t i o n ( ) ;  
  
 	 	 / / C a l c u l a t e   t h e   r o w / c o l   c l i c k e d  
 	 	 i n t   r o w   =   0 ;  
 	 	 i n t   c o l   =   0 ;  
 	 	 r o w   =   C o n v e r t . T o I n t 3 2 ( M a t h . F l o o r ( ( m o u s e . Y )   /   ( C E L L _ H E I G H T   +   C E L L _ G A P ) ) ) ;  
 	 	 c o l   =   C o n v e r t . T o I n t 3 2 ( M a t h . F l o o r ( ( m o u s e . X   -   F I E L D _ L E F T )   /   ( C E L L _ W I D T H   +   C E L L _ G A P ) ) ) ;  
  
 	 	 i f   ( r o w   > =   0   &   r o w   <   H u m a n P l a y e r . P l a y e r G r i d . H e i g h t )   {  
 	 	 	 i f   ( c o l   > =   0   &   c o l   <   H u m a n P l a y e r . P l a y e r G r i d . W i d t h )   {  
 	 	 	 	 / / i f   i n   t h e   a r e a   t r y   t o   d e p l o y  
 	 	 	 	 t r y   {  
 	 	 	 	 	 H u m a n P l a y e r . P l a y e r G r i d . M o v e S h i p ( r o w ,   c o l ,   _ s e l e c t e d S h i p ,   _ c u r r e n t D i r e c t i o n ) ;  
 	 	 	 	 }   c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 	 A u d i o . P l a y S o u n d E f f e c t ( G a m e S o u n d ( " E r r o r " ) ) ;  
 	 	 	 	 	 M e s s a g e   =   e x . M e s s a g e ;  
 	 	 	 	 }  
 	 	 	 }  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   D r a w s   t h e   d e p l o y m e n t   s c r e e n   s h o w i n g   t h e   f i e l d   a n d   t h e   s h i p s  
 	 / / /   t h a t   t h e   p l a y e r   c a n   d e p l o y .  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   s t a t i c   v o i d   D r a w D e p l o y m e n t ( )  
 	 {  
 	 	 D r a w F i e l d ( H u m a n P l a y e r . P l a y e r G r i d ,   H u m a n P l a y e r ,   t r u e ) ;  
  
 	 	 / / D r a w   t h e   L e f t / R i g h t   a n d   U p / D o w n   b u t t o n s  
 	 	 i f   ( _ c u r r e n t D i r e c t i o n   = =   D i r e c t i o n . L e f t R i g h t )   {  
 	 	 	 S w i n G a m e . D r a w B i t m a p ( G a m e I m a g e ( " L e f t R i g h t B u t t o n " ) ,   L E F T _ R I G H T _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P ) ;  
 	 	 	 / / S w i n G a m e . D r a w T e x t ( " U / D " ,   C o l o r . G r a y ,   G a m e F o n t ( " M e n u " ) ,   U P _ D O W N _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P )  
 	 	 	 / / S w i n G a m e . D r a w T e x t ( " L / R " ,   C o l o r . W h i t e ,   G a m e F o n t ( " M e n u " ) ,   L E F T _ R I G H T _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P )  
 	 	 }   e l s e   {  
 	 	 	 S w i n G a m e . D r a w B i t m a p ( G a m e I m a g e ( " U p D o w n B u t t o n " ) ,   L E F T _ R I G H T _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P ) ;  
 	 	 	 / / S w i n G a m e . D r a w T e x t ( " U / D " ,   C o l o r . W h i t e ,   G a m e F o n t ( " M e n u " ) ,   U P _ D O W N _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P )  
 	 	 	 / / S w i n G a m e . D r a w T e x t ( " L / R " ,   C o l o r . G r a y ,   G a m e F o n t ( " M e n u " ) ,   L E F T _ R I G H T _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P )  
 	 	 }  
  
 	 	 / / D r a w S h i p s  
 	 	 f o r e a c h   ( S h i p N a m e   s n   i n   E n u m . G e t V a l u e s ( t y p e o f ( S h i p N a m e ) ) )   {  
 	 	 	 i n t   i   =   0 ;  
 	 	 	 i   =   C o n v e r s i o n . I n t ( s n )   -   1 ;  
 	 	 	 i f   ( i   > =   0 )   {  
 	 	 	 	 i f   ( s n   = =   _ s e l e c t e d S h i p )   {  
 	 	 	 	 	 S w i n G a m e . D r a w B i t m a p ( G a m e I m a g e ( " S e l e c t e d S h i p " ) ,   S H I P S _ L E F T ,   S H I P S _ T O P   +   i   *   S H I P S _ H E I G H T ) ;  
 	 	 	 	 	 / /         S w i n G a m e . F i l l R e c t a n g l e ( C o l o r . L i g h t B l u e ,   S H I P S _ L E F T ,   S H I P S _ T O P   +   i   *   S H I P S _ H E I G H T ,   S H I P S _ W I D T H ,   S H I P S _ H E I G H T )  
 	 	 	 	 	 / / E l s e  
 	 	 	 	 	 / /         S w i n G a m e . F i l l R e c t a n g l e ( C o l o r . G r a y ,   S H I P S _ L E F T ,   S H I P S _ T O P   +   i   *   S H I P S _ H E I G H T ,   S H I P S _ W I D T H ,   S H I P S _ H E I G H T )  
 	 	 	 	 }  
  
 	 	 	 	 / / S w i n G a m e . D r a w R e c t a n g l e ( C o l o r . B l a c k ,   S H I P S _ L E F T ,   S H I P S _ T O P   +   i   *   S H I P S _ H E I G H T ,   S H I P S _ W I D T H ,   S H I P S _ H E I G H T )  
 	 	 	 	 / / S w i n G a m e . D r a w T e x t ( s n . T o S t r i n g ( ) ,   C o l o r . B l a c k ,   G a m e F o n t ( " C o u r i e r " ) ,   S H I P S _ L E F T   +   T E X T _ O F F S E T ,   S H I P S _ T O P   +   i   *   S H I P S _ H E I G H T )  
  
 	 	 	 }  
 	 	 }  
  
 	 	 i f   ( H u m a n P l a y e r . R e a d y T o D e p l o y )   {  
 	 	 	 S w i n G a m e . D r a w B i t m a p ( G a m e I m a g e ( " P l a y B u t t o n " ) ,   P L A Y _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P ) ;  
 	 	 	 / / S w i n G a m e . F i l l R e c t a n g l e ( C o l o r . L i g h t B l u e ,   P L A Y _ B U T T O N _ L E F T ,   P L A Y _ B U T T O N _ T O P ,   P L A Y _ B U T T O N _ W I D T H ,   P L A Y _ B U T T O N _ H E I G H T )  
 	 	 	 / / S w i n G a m e . D r a w T e x t ( " P L A Y " ,   C o l o r . B l a c k ,   G a m e F o n t ( " C o u r i e r " ) ,   P L A Y _ B U T T O N _ L E F T   +   T E X T _ O F F S E T ,   P L A Y _ B U T T O N _ T O P )  
 	 	 }  
  
 	 	 S w i n G a m e . D r a w B i t m a p ( G a m e I m a g e ( " R a n d o m B u t t o n " ) ,   R A N D O M _ B U T T O N _ L E F T ,   T O P _ B U T T O N S _ T O P ) ;  
  
 	 	 D r a w M e s s a g e ( ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   G e t s   t h e   s h i p   t h a t   t h e   m o u s e   i s   c u r r e n t l y   o v e r   i n   t h e   s e l e c t i o n   p a n e l .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e t u r n s > T h e   s h i p   s e l e c t e d   o r   n o n e < / r e t u r n s >  
 	 p r i v a t e   s t a t i c   S h i p N a m e   G e t S h i p M o u s e I s O v e r ( )  
 	 {  
 	 	 f o r e a c h   ( S h i p N a m e   s n   i n   E n u m . G e t V a l u e s ( t y p e o f ( S h i p N a m e ) ) )   {  
 	 	 	 i n t   i   =   0 ;  
 	 	 	 i   =   C o n v e r s i o n . I n t ( s n )   -   1 ;  
  
 	 	 	 i f   ( I s M o u s e I n R e c t a n g l e ( S H I P S _ L E F T ,   S H I P S _ T O P   +   i   *   S H I P S _ H E I G H T ,   S H I P S _ W I D T H ,   S H I P S _ H E I G H T ) )   {  
 	 	 	 	 r e t u r n   s n ;  
 	 	 	 }  
 	 	 }  
  
 	 	 r e t u r n   S h i p N a m e . N o n e ;  
 	 }  
 } 