// MFC Client.h : main header file for the MFC CLIENT application
//

#if !defined(AFX_MFCCLIENT_H__FDC42194_7837_11D3_A7DE_0000E885A202__INCLUDED_)
#define AFX_MFCCLIENT_H__FDC42194_7837_11D3_A7DE_0000E885A202__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"       // main symbols

/////////////////////////////////////////////////////////////////////////////
// CMFCClientApp:
// See MFC Client.cpp for the implementation of this class
//

class CMFCClientApp : public CWinApp
{
public:
	CMFCClientApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMFCClientApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation
	COleTemplateServer m_server;
		// Server object for document creation
	//{{AFX_MSG(CMFCClientApp)
	afx_msg void OnAppAbout();
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MFCCLIENT_H__FDC42194_7837_11D3_A7DE_0000E885A202__INCLUDED_)
