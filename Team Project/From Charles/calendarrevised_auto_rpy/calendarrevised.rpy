I-Logix-RPY-Archive version 8.5.2 Modeler C++ 1159120
{ IProject 
	- _id = GUID b17b4db0-4e7a-43ee-95c2-531be883fab8;
	- _myState = 8192;
	- _name = "calendarrevised";
	- _objectCreation = "5020487125820211520066450";
	- _umlDependencyID = "3211";
	- _UserColors = { IRPYRawContainer 
		- size = 16;
		- value = 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 
	}
	- _defaultSubsystem = { ISubsystemHandle 
		- _m2Class = "ISubsystem";
		- _filename = "Default.sbs";
		- _subsystem = "";
		- _class = "";
		- _name = "Default";
		- _id = GUID c47ab2c9-24f3-4a79-985d-f2f6c96524ba;
	}
	- _component = { IHandle 
		- _m2Class = "IComponent";
		- _filename = "DefaultComponent.cmp";
		- _subsystem = "";
		- _class = "";
		- _name = "DefaultComponent";
		- _id = GUID 2ae9e371-f38e-4485-9446-5d27500321e9;
	}
	- Multiplicities = { IRPYRawContainer 
		- size = 4;
		- value = 
		{ IMultiplicityItem 
			- _name = "1";
			- _count = -1;
		}
		{ IMultiplicityItem 
			- _name = "*";
			- _count = -1;
		}
		{ IMultiplicityItem 
			- _name = "0,1";
			- _count = -1;
		}
		{ IMultiplicityItem 
			- _name = "1..*";
			- _count = -1;
		}
	}
	- Subsystems = { IRPYRawContainer 
		- size = 1;
		- value = 
		{ ISubsystem 
			- fileName = "Default";
			- _id = GUID c47ab2c9-24f3-4a79-985d-f2f6c96524ba;
		}
	}
	- Diagrams = { IRPYRawContainer 
		- size = 1;
		- value = 
		{ IDiagram 
			- _id = GUID 39957ef5-b331-46f1-8858-61fd717c4e06;
			- _myState = 8192;
			- _properties = { IPropertyContainer 
				- Subjects = { IRPYRawContainer 
					- size = 1;
					- value = 
					{ IPropertySubject 
						- _Name = "Format";
						- Metaclasses = { IRPYRawContainer 
							- size = 3;
							- value = 
							{ IPropertyMetaclass 
								- _Name = "Association";
								- Properties = { IRPYRawContainer 
									- size = 5;
									- value = 
									{ IProperty 
										- _Name = "Font.Font";
										- _Value = "Arial";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Font.FontColor";
										- _Value = "0,0,128";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Size";
										- _Value = "10";
										- _Type = Int;
									}
									{ IProperty 
										- _Name = "Line.LineColor";
										- _Value = "221,0,0";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Line.LineWidth";
										- _Value = "1";
										- _Type = Int;
									}
								}
							}
							{ IPropertyMetaclass 
								- _Name = "Class";
								- Properties = { IRPYRawContainer 
									- size = 8;
									- value = 
									{ IProperty 
										- _Name = "DefaultSize";
										- _Value = "0,34,84,148";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Fill.FillColor";
										- _Value = "255,255,255";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Font";
										- _Value = "Arial";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Font.FontColor";
										- _Value = "0,0,0";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Size";
										- _Value = "10";
										- _Type = Int;
									}
									{ IProperty 
										- _Name = "Line.LineColor";
										- _Value = "121,122,0";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Line.LineStyle";
										- _Value = "0";
										- _Type = Int;
									}
									{ IProperty 
										- _Name = "Line.LineWidth";
										- _Value = "1";
										- _Type = Int;
									}
								}
							}
							{ IPropertyMetaclass 
								- _Name = "Inheritance";
								- Properties = { IRPYRawContainer 
									- size = 5;
									- value = 
									{ IProperty 
										- _Name = "Font.Font";
										- _Value = "Arial";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Font.FontColor";
										- _Value = "0,0,128";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Size";
										- _Value = "10";
										- _Type = Int;
									}
									{ IProperty 
										- _Name = "Line.LineColor";
										- _Value = "0,16,230";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Line.LineWidth";
										- _Value = "1";
										- _Type = Int;
									}
								}
							}
						}
					}
				}
			}
			- _name = "calendar";
			- _objectCreation = "5020489125820211520064450";
			- _umlDependencyID = "2457";
			- _lastModifiedTime = "4.12.2021::19:20:30";
			- _graphicChart = { CGIClassChart 
				- _id = GUID d8e21123-fe5f-4056-88dc-dda6a54b7361;
				- m_type = 0;
				- m_pModelObject = { IHandle 
					- _m2Class = "IDiagram";
					- _id = GUID 39957ef5-b331-46f1-8858-61fd717c4e06;
				}
				- m_pParent = ;
				- m_name = { CGIText 
					- m_str = "";
					- m_style = "Arial" 10 0 0 0 1 ;
					- m_color = { IColor 
						- m_fgColor = 0;
						- m_bgColor = 0;
						- m_bgFlag = 0;
					}
					- m_position = 1 0 0  ;
					- m_nIdent = 0;
					- m_bImplicitSetRectPoints = 0;
					- m_nOrientationCtrlPt = 8;
				}
				- m_drawBehavior = 0;
				- m_bIsPreferencesInitialized = 0;
				- elementList = 7;
				{ CGIClass 
					- _id = GUID 3ab22166-c508-4c59-8862-5c253c70c058;
					- m_type = 78;
					- m_pModelObject = { IHandle 
						- _m2Class = "IClass";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "TopLevel";
						- _id = GUID c8986453-7695-49f2-bd44-b8c48ee3ec36;
					}
					- m_pParent = ;
					- m_name = { CGIText 
						- m_str = "TopLevel";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 0;
					- m_bIsPreferencesInitialized = 0;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_polygon = 0 ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
					- Attrs = { IRPYRawContainer 
						- size = 0;
					}
					- Operations = { IRPYRawContainer 
						- size = 0;
					}
				}
				{ CGIClass 
					- _id = GUID f1320a11-347a-4ca0-8f8f-684c51a66214;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 2;
							- value = 
							{ IPropertySubject 
								- _Name = "Format";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Class";
										- Properties = { IRPYRawContainer 
											- size = 2;
											- value = 
											{ IProperty 
												- _Name = "Font.Italic";
												- _Value = "1";
												- _Type = Int;
											}
											{ IProperty 
												- _Name = "Font.Weight";
												- _Value = "400";
												- _Type = Int;
											}
										}
									}
								}
							}
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "FitBoxToItsTextuals";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 87;
					- m_pModelObject = { IHandle 
						- _m2Class = "IClass";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "User";
						- _id = GUID fc573900-7e7d-4534-9b37-9f4364945dd0;
					}
					- m_pParent = GUID 3ab22166-c508-4c59-8862-5c253c70c058;
					- m_name = { CGIText 
						- m_str = "User";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 2056;
					- m_transform = 0.309726 0 0 0.145276 -0.6194 13.2041 ;
					- m_bIsPreferencesInitialized = 1;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_bFramesetModified = 1;
					- m_polygon = 4 2 329  2 1451  1061 1451  1061 329  ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
					- frameset = "<frameset rows=54%,46%>
<frame name=AttributeListCompartment>
<frame name=PrimitiveOperationListCompartment>";
					- Attrs = { IRPYRawContainer 
						- size = 4;
						- value = 
						{ IHandle 
							- _m2Class = "IAttribute";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "User";
							- _name = "userID";
							- _id = GUID a985e23e-c528-435b-b574-9cf26fb7e8f8;
						}
						{ IHandle 
							- _m2Class = "IAttribute";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "User";
							- _name = "name";
							- _id = GUID 984c9735-5767-43a0-a8a7-694c9d14b48e;
						}
						{ IHandle 
							- _m2Class = "IAttribute";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "User";
							- _name = "address";
							- _id = GUID 8d117df5-ce95-4d24-b5f6-6b07bb106a27;
						}
						{ IHandle 
							- _m2Class = "IAttribute";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "User";
							- _name = "userType";
							- _id = GUID 71667154-49b9-4f6d-ad09-df1bd5ae2053;
						}
					}
					- Operations = { IRPYRawContainer 
						- size = 2;
						- value = 
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "User";
							- _name = "getDetails()";
							- _id = GUID 616a7e20-ba88-4bfd-bf66-2333a7731aaa;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "User";
							- _name = "setDetails(int,char*,char*)";
							- _id = GUID 09da1b47-75cd-4edd-bf5f-8cd1d4ff366d;
						}
					}
				}
				{ CGIClass 
					- _id = GUID 1f2cdf5a-64c8-41cc-a001-cf0b5a944dfb;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 1;
							- value = 
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "FitBoxToItsTextuals";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 87;
					- m_pModelObject = { IHandle 
						- _m2Class = "IClass";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "Manager";
						- _id = GUID fb6f2476-5fba-4f83-a33b-484d4b126022;
					}
					- m_pParent = GUID 3ab22166-c508-4c59-8862-5c253c70c058;
					- m_name = { CGIText 
						- m_str = "Manager";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 2056;
					- m_transform = 0.312559 0 0 0.180927 120.375 364.475 ;
					- m_bIsPreferencesInitialized = 1;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_bFramesetModified = 1;
					- m_polygon = 4 2 329  2 1451  1061 1451  1061 329  ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
					- frameset = "<frameset rows=36%,64%>
<frame name=AttributeListCompartment>
<frame name=PrimitiveOperationListCompartment>";
					- Attrs = { IRPYRawContainer 
						- size = 2;
						- value = 
						{ IHandle 
							- _m2Class = "IAttribute";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "Manager";
							- _name = "managerID";
							- _id = GUID fc89ccce-285f-4041-ab16-9bf31e89ce16;
						}
						{ IHandle 
							- _m2Class = "IAttribute";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "Manager";
							- _name = "serviceType";
							- _id = GUID c024387e-6961-4f4e-9611-decc692701ba;
						}
					}
					- Operations = { IRPYRawContainer 
						- size = 5;
						- value = 
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "Manager";
							- _name = "cancelMeeting(char*)";
							- _id = GUID 26c39514-7e0b-499b-ac1e-71c51a6a6fec;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "Manager";
							- _name = "requestCancellation()";
							- _id = GUID 784930ce-a91a-4621-baab-f55d65ec114e;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "Manager";
							- _name = "confirmCancellation(char*)";
							- _id = GUID df3c53cc-2cdc-4624-b760-ec6a6840e040;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "Manager";
							- _name = "requestExit()";
							- _id = GUID 77145e18-f501-447e-958e-09d7cbbbaa16;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "Manager";
							- _name = "setUserType(char*)";
							- _id = GUID 92f8ad97-429e-41d2-ab27-31b1b5b2afe0;
						}
					}
				}
				{ CGIInheritance 
					- _id = GUID 85b2c1da-6d80-40b8-9d5b-03ad99da8df4;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 1;
							- value = 
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "ShowLabels";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 103;
					- m_pModelObject = { IHandle 
						- _m2Class = "IGeneralization";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "Manager";
						- _name = "User";
						- _id = GUID ca402516-edef-4064-b3f6-e53094fa405d;
					}
					- m_pParent = ;
					- m_name = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_drawBehavior = 8;
					- m_bIsPreferencesInitialized = 1;
					- m_pSource = GUID 1f2cdf5a-64c8-41cc-a001-cf0b5a944dfb;
					- m_sourceType = 'F';
					- m_pTarget = GUID f1320a11-347a-4ca0-8f8f-684c51a66214;
					- m_targetType = 'T';
					- m_direction = ' ';
					- m_rpn = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_anglePoint1 = 0 0 ;
					- m_anglePoint2 = 0 0 ;
					- m_line_style = 0;
					- m_SourcePort = 546 329 ;
					- m_TargetPort = 525 1451 ;
					- m_ShowName = 0;
					- m_ShowStereotype = 1;
				}
				{ CGIClass 
					- _id = GUID 234d591f-d0d0-44cb-b726-4c3d3446bc3d;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 1;
							- value = 
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "FitBoxToItsTextuals";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 87;
					- m_pModelObject = { IHandle 
						- _m2Class = "IClass";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "calendar";
						- _id = GUID 91967e95-108d-4087-af33-264c39ccdbe3;
					}
					- m_pParent = GUID 3ab22166-c508-4c59-8862-5c253c70c058;
					- m_name = { CGIText 
						- m_str = "calendar";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 2056;
					- m_transform = 0.362606 0 0 0.286096 596.275 -40.1256 ;
					- m_bIsPreferencesInitialized = 1;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_bFramesetModified = 1;
					- m_polygon = 4 2 329  2 1451  1061 1451  1061 329  ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
					- frameset = "<frameset rows=25%,75%>
<frame name=AttributeListCompartment>
<frame name=PrimitiveOperationListCompartment>";
					- Attrs = { IRPYRawContainer 
						- size = 3;
						- value = 
						{ IHandle 
							- _m2Class = "IAttribute";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "calendarID";
							- _id = GUID 5369cbcb-cb42-477d-9604-f21a88116571;
						}
						{ IHandle 
							- _m2Class = "IAttribute";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "userAssociatedID";
							- _id = GUID 402a3ed0-b11f-4221-882f-d25c044c1e98;
						}
						{ IHandle 
							- _m2Class = "IAttribute";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "eventsName";
							- _id = GUID b5211e7c-1d7a-4819-81d1-ee5763e92476;
						}
					}
					- Operations = { IRPYRawContainer 
						- size = 12;
						- value = 
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "displayPlacedEvents(char*)";
							- _id = GUID e51faac2-1fd7-4f0c-a0e2-fdd70a7f5cf3;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "displayAllPlacedEvents()";
							- _id = GUID fd212136-d6b3-4043-abb0-93d7db08d327;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "saveEvent(char*)";
							- _id = GUID 8f674a54-ffc2-4b26-86a3-611e107b643d;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "searchEvent(char*,char*)";
							- _id = GUID 0fe1d6d2-3d3d-49ed-8ee5-f8b10c818f8e;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "displaySelectedEvents(char*)";
							- _id = GUID f654200d-2a2a-4330-ac05-1aa409ef0d79;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "displayMenuChoices()";
							- _id = GUID c256d727-fa23-4c3b-9160-6789578117c7;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "exitEvent(char*)";
							- _id = GUID 88446887-de05-4645-aaad-554f2ce0607e;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "checkUserType()";
							- _id = GUID f28b2615-55ba-412a-ae07-0882e7aa4134;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "displayDeletionWarning()";
							- _id = GUID d2e6d998-3671-4890-8a37-c420e11b5c60;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "displayMeetingList(int)";
							- _id = GUID 23d69d42-4235-45c9-bab3-60cb69606e4a;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "deleteMeetingEvent(char*,char*)";
							- _id = GUID a2809733-78a0-4909-a03b-4b78d62eb430;
						}
						{ IHandle 
							- _m2Class = "IPrimitiveOperation";
							- _filename = "Default.sbs";
							- _subsystem = "Default";
							- _class = "calendar";
							- _name = "displayMainCalender()";
							- _id = GUID 98390c79-1d80-4233-abb1-74e373b444fe;
						}
					}
				}
				{ CGIAssociationEnd 
					- _id = GUID 4a78e6ad-c015-4f10-bb87-504a50fa2daf;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 1;
							- value = 
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "ShowLabels";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 92;
					- m_pModelObject = { IHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "calendar";
						- _name = "itsManager";
						- _id = GUID 4336e45b-ca10-4ac2-93aa-82231a4b66f4;
					}
					- m_pParent = ;
					- m_name = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_drawBehavior = 0;
					- m_bIsPreferencesInitialized = 1;
					- m_pSource = GUID 234d591f-d0d0-44cb-b726-4c3d3446bc3d;
					- m_sourceType = 'F';
					- m_pTarget = GUID 1f2cdf5a-64c8-41cc-a001-cf0b5a944dfb;
					- m_targetType = 'T';
					- m_direction = ' ';
					- m_rpn = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 4 -48 -8  23 -8  23 10  -48 10  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_transform = 1 0 0 1 516 262 ;
						- m_nHorizontalSpacing = -34;
						- m_nOrientationCtrlPt = 7;
					}
					- m_arrow = 2 502 278  502 454  ;
					- m_anglePoint1 = 0 0 ;
					- m_anglePoint2 = 0 0 ;
					- m_line_style = 2;
					- m_SourcePort = 2 1112 ;
					- m_TargetPort = 1061 495 ;
					- m_pInverseModelObject = { IAssociationEndHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "Manager";
						- _name = "itsCalendar";
						- _id = GUID 70d80e81-d89f-426a-ac81-326d837bb449;
					}
					- m_pInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_pInverseInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_bShowSourceMultiplicity = 1;
					- m_bShowSourceRole = 0;
					- m_bShowTargetMultiplicity = 1;
					- m_bShowTargetRole = 0;
					- m_bShowLinkName = 1;
					- m_bShowSpecificType = 0;
					- m_bInstance = 0;
					- m_bShowQualifier1 = 1;
					- m_bShowQualifier2 = 1;
					- m_sourceRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 2;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 3;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceMultiplicity = { CGIText 
						- m_str = "1";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 4;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 4;
					}
					- m_targetMultiplicity = { CGIText 
						- m_str = "1";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 5;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 6;
					}
					- m_sourceQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 6;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_targetQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 7;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_specificType = symmetric_type;
				}
				{ CGIAssociationEnd 
					- _id = GUID be2ce889-a042-43d8-a75e-42511b6e128c;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 1;
							- value = 
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "ShowLabels";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 92;
					- m_pModelObject = { IHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "User";
						- _name = "itsCalendar";
						- _id = GUID 9a6c130e-e56d-49ed-b962-0d8187f19773;
					}
					- m_pParent = ;
					- m_name = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_drawBehavior = 0;
					- m_bIsPreferencesInitialized = 1;
					- m_pSource = GUID f1320a11-347a-4ca0-8f8f-684c51a66214;
					- m_sourceType = 'F';
					- m_pTarget = GUID 234d591f-d0d0-44cb-b726-4c3d3446bc3d;
					- m_targetType = 'T';
					- m_direction = ' ';
					- m_rpn = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 7;
					}
					- m_anglePoint1 = 0 0 ;
					- m_anglePoint2 = 0 0 ;
					- m_line_style = 2;
					- m_SourcePort = 1058 570 ;
					- m_TargetPort = 10 476 ;
					- m_pInverseModelObject = { IAssociationEndHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "calendar";
						- _name = "itsUser";
						- _id = GUID e7caac99-7501-455a-88e3-059275bd91a9;
					}
					- m_pInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_pInverseInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_bShowSourceMultiplicity = 1;
					- m_bShowSourceRole = 0;
					- m_bShowTargetMultiplicity = 1;
					- m_bShowTargetRole = 0;
					- m_bShowLinkName = 1;
					- m_bShowSpecificType = 0;
					- m_bInstance = 0;
					- m_bShowQualifier1 = 1;
					- m_bShowQualifier2 = 1;
					- m_sourceRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 2;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 3;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceMultiplicity = { CGIText 
						- m_str = "1";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 4;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 6;
					}
					- m_targetMultiplicity = { CGIText 
						- m_str = "1";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 5;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 4;
					}
					- m_sourceQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 6;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_targetQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 7;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_specificType = symmetric_type;
				}
				
				- m_access = 'Z';
				- m_modified = 'N';
				- m_fileVersion = "";
				- m_nModifyDate = 0;
				- m_nCreateDate = 0;
				- m_creator = "";
				- m_bScaleWithZoom = 1;
				- m_arrowStyle = 'S';
				- m_pRoot = GUID 3ab22166-c508-4c59-8862-5c253c70c058;
				- m_currentLeftTop = 0 0 ;
				- m_currentRightBottom = 0 0 ;
			}
			- _defaultSubsystem = { IHandle 
				- _m2Class = "ISubsystem";
				- _filename = "Default.sbs";
				- _subsystem = "";
				- _class = "";
				- _name = "Default";
				- _id = GUID c47ab2c9-24f3-4a79-985d-f2f6c96524ba;
			}
		}
	}
	- Components = { IRPYRawContainer 
		- size = 1;
		- value = 
		{ IComponent 
			- fileName = "DefaultComponent";
			- _id = GUID 2ae9e371-f38e-4485-9446-5d27500321e9;
		}
	}
}

