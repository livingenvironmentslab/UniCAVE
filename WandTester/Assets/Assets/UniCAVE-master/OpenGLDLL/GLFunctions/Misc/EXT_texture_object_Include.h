#define GLI_INCLUDE_GL_EXT_TEXTURE_OBJECT

enum Main {

  //GL_TEXTURE_PRIORITY_EXT         = 0x8066,
  //GL_TEXTURE_RESIDENT_EXT         = 0x8067,
  //GL_TEXTURE_1D_BINDING_EXT       = 0x8068,
  //GL_TEXTURE_2D_BINDING_EXT       = 0x8069,
  //GL_TEXTURE_3D_BINDING_EXT       = 0x806A,

};

GLboolean glAreTexturesResidentEXT( GLsizei n, const GLuint *textures, GLboolean *residences );
void glBindTextureEXT(GLenum[Main] target, GLimageindex texture );
void glDeleteTexturesEXT( GLsizei n, const GLuint *textures);
void glGenTexturesEXT( GLsizei n, GLuint *textures );
GLboolean glIsTextureEXT( GLuint texture );
void glPrioritizeTexturesEXT( GLsizei n, const GLuint *textures, const GLfloat *priorities );

