import maya.cmds as cmds

def create_joint_hierarchy():
    selected_joints = cmds.ls(selection=True, type="joint")

    if not selected_joints:
        cmds.warning("No joints selected!")
        return

    for joint in selected_joints:
        # Get joint position
        joint_position = cmds.xform(joint, query=True, translation=True, worldSpace=True)

        # Create NURBS curve (control) at joint's position
        control_curve = cmds.circle(name=joint + "_ctrl")[0]
        cmds.move(joint_position[0], joint_position[1], joint_position[2], control_curve)

        # Create empty group (parent group) at joint's position
        parent_group = cmds.group(empty=True, name=joint + "_grp")
        cmds.move(joint_position[0], joint_position[1], joint_position[2], parent_group)

        # Parent the control under the parent group
        cmds.parent(control_curve, parent_group)

        # Parent constraint the joint to the control
        cmds.parentConstraint(control_curve, joint, maintainOffset=True)

        # Rename the parent group according to established naming conventions
        parent_group_name = joint.replace("_jnt", "_grp")
        cmds.rename(parent_group, parent_group_name)

create_joint_hierarchy()
